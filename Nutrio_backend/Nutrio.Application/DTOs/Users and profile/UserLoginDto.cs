using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nutrio.Application.DTOs.Users_and_profile
{
    public class UserLoginDto
    {
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(8 )]
        public string Password { get; set; } = string.Empty;
    }
}
