using Nutrio.Application.DTOs;
using Nutrio.Application.DTOs.Users_and_profile;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.Interfaces
{
    internal class IUserService
    {
        Task<UserAuthResponseDto> RegisterAsync(UserRegisterDto registerDto);
        Task<UserAuthResponseDto> LoginAsync(UserLoginDto loginDto);
        Task<UserAuthResponseDto> LoginWithGoogleAsync(string googleToken);

        Task<UserProfileDto> GetProfileAsync(Guid userId);
        Task<bool> UpdateProfileAsync(Guid userId, UserProfileDto profileDto);
    }
}
