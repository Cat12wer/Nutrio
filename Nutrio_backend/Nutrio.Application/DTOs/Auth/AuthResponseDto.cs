using System;
using System.Collections.Generic;
using System.Text;
using Nutrio.Application.DTOs.Users_and_profile;

namespace Nutrio.Application.DTOs.Auth
{
    public class AuthResponseDto 
    {
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;

        public UserProfileDto UserProfile { get; set; } = null!;
       

    }
}
