using Nutrio.Application.DTOs.Users_and_profile;
using Nutrio.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.Interfaces
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(UserRegistreDto registrerDto);

        Task<UserAuthResponseDto?> LoginAsync(UserLoginDto loginDto);

        Task<AuthResponseDto> GoogleLoginAsync(string googleToken);

        Task<AuthResponseDto?> RefreshTokenAsync(string refreshToken);

        Task<bool> LogoutAsync(Guid userId);
    }
}
