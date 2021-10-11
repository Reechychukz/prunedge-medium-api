using Application.Helpers;
using Application.Services.Implementations;
using System;

namespace Application.Services.Interfaces
{
    public interface IJwtAuthenticationManager: IAutoDependencyService
    {
        bool ValidateRefreshToken(string refreshToken);
    }
}
