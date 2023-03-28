using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Http;
using FarmaNetBackend.IRepositories;

namespace FarmaNetBackend.Authorization
{
    [ApiController]
    public class AuthorizationController
    {
        private readonly IAuthorizationRepository _repository;

        public AuthorizationController(IAuthorizationRepository repository)
        {
            _repository = repository;
        }

        private string GetAuthorizationToken(WorkerAccount account)
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, account.Login, account.Password) };
            
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromHours(2)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        [HttpPost]
        [Route("/authorization")]
        public IResult Login(WorkerAccount account)
        {
            WorkerAccount person = _repository.Login(account);

            if (person == null) {
                return null;
            }

            var data = new {
                token = GetAuthorizationToken(account),
                workerInformationId = person.WorkerInformationId
            };

            return Results.Json(data);
        }
    }
}
