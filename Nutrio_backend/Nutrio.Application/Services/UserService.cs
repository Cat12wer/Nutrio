using Google.Apis.Auth;
using Microsoft.Extensions.Configuration;
using Nutrio.Application.DTOs;
using Nutrio.Application.DTOs.Users_and_profile;
using Nutrio.Application.Interfaces;
using Nutrio.Domain.Entities;
using Nutrio.Domain.Interfaces;


namespace Nutrio.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public UserService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<UserAuthResponseDto> RegisterAsync(UserRegistreDto registerDto)
        {
            // Використовуємо .User (як у твоєму IUnitOfWork)
            var isUnique = await _unitOfWork.User.IsEmailUniqueAsync(registerDto.Email);
            if (!isUnique) throw new Exception("Email вже зайнятий.");

            var user = new Users
            {
                Id = Guid.NewGuid(),
                Email = registerDto.Email,
                Name = registerDto.Name,
                LastName = registerDto.LastName,
                Password = registerDto.Password,
                BirthDate = registerDto.BirthDate,
                Sex = registerDto.sex,
                Weight = registerDto.Weight, 
                Height = registerDto.Height
            };

            await _unitOfWork.User.AddAsync(user);
            await _unitOfWork.SaveChangesAsync(); // Виправлено назву методу

            return new UserAuthResponseDto { Id = user.Id, Email = user.Email, Name = user.Name };
        }

        public async Task<UserAuthResponseDto> LoginWithGoogleAsync(UserGoogleAuthDto googleDto)
        {
            var clientId = _configuration["Authentication:Google:ClientId"];
            var settings = new GoogleJsonWebSignature.ValidationSettings { Audience = new[] { clientId } };

            try
            {
                var payload = await GoogleJsonWebSignature.ValidateAsync(googleDto.IdToken, settings);
                var user = await _unitOfWork.User.GetByEmailAsync(payload.Email);

                if (user == null)
                {
                    user = new Users
                    {
                        Id = Guid.NewGuid(),
                        Email = payload.Email,
                        Name = payload.GivenName,
                        LastName = payload.FamilyName,
                        GoogleId = payload.Subject,
                        Password = "",
                        BirthDate = DateOnly.FromDateTime(DateTime.Now),
                        Sex = Sex.NotSpecified, 
                        Weight = 0,
                        Height = 0
                    };
                    await _unitOfWork.User.AddAsync(user);
                    await _unitOfWork.SaveChangesAsync();
                }

                return new UserAuthResponseDto { Id = user.Id, Email = user.Email, Name = user.Name };
            }
            catch { throw new Exception("Помилка валідації Google."); }
        }

        public async Task<UserAuthResponseDto> LoginAsync(UserLoginDto loginDto)
        {
            var user = await _unitOfWork.User.GetByEmailAsync(loginDto.Email);
            if (user == null || user.Password != loginDto.Password)
                throw new Exception("Невірний логін або пароль.");

            return new UserAuthResponseDto { Id = user.Id, Email = user.Email, Name = user.Name };
        }

        public async Task<UserProfileDto> GetProfileAsync(Guid userId)
        {
            var user = await _unitOfWork.User.GetByIdAsync(userId);
            if (user == null) throw new Exception("Користувача не знайдено.");

            return new UserProfileDto
            {
                Id = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Weight = user.Weight,
                Height = user.Height,
                Sex = user.Sex, // Тепер без помилки CS0572
                Age = DateTime.Now.Year - user.BirthDate.Year
            };
        }

        public Task<bool> UpdateProfileAsync(Guid userId, UserProfileDto profileDto)
        {
            throw new NotImplementedException();
        }
    }
}