using Nutrio.Application.DTOs;
using Nutrio.Application.DTOs.Users_and_profile;
using System;
using System.Collections.Generic;
using System.Text;
using Google.Apis.Auth;
using Nutrio.Application.DTOs;
using Nutrio.Application.DTOs.Users_and_profile;

namespace Nutrio.Application.Interfaces
{
        public interface IUserService
        {
            Task<UserAuthResponseDto> RegisterAsync(UserRegistreDto registerDto);
            Task<UserAuthResponseDto> LoginAsync(UserLoginDto loginDto);
            Task<UserAuthResponseDto> LoginWithGoogleAsync(UserGoogleAuthDto googleDto);
            Task<UserProfileDto> GetProfileAsync(Guid userId);
            Task<bool> UpdateProfileAsync(Guid userId, UserProfileDto profileDto);
        }
}
