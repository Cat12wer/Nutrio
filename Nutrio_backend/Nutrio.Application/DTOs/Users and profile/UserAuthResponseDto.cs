using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs.Users_and_profile
{
    public class UserAuthResponseDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public bool IsOnboarded { get; set; } 
    }
}
