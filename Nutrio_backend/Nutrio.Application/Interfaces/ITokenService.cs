using Nutrio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Nutrio.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateAccessToken(Users user);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
    }
}
