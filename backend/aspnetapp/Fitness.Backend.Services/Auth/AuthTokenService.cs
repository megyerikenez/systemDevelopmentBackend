﻿using Fitness.Backend.Application.Contracts.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Backend.Services.Auth
{
    public class AuthTokenService : IAuthTokenService
    {
        private readonly IConfiguration _configuration;
        public AuthTokenService(IConfiguration config)
        {
            _configuration = config;
        }

        public JwtSecurityToken GenerateToken(List<Claim> authClaims)
        {


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                authClaims,
                expires: DateTime.UtcNow.AddMinutes(1),
                signingCredentials: signIn);

            return token;
        }
    }
}
