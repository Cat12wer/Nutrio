using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs.Users_and_profile
{
    internal class UserLoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
