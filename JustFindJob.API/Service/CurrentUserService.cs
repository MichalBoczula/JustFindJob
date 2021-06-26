using IdentityModel;
using JustFindJob.Application.Contracts.Identity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JustFindJob.API.Service
{
    public class CurrentUserService : ICurrentUserService
    {
        public string  Email { get; set; }
        public bool IsAuthenticated { get; set; }

        public CurrentUserService(IHttpContextAccessor httpContext)
        {
            var email = httpContext.HttpContext?.User?.FindFirstValue(JwtClaimTypes.Email);
            Email = email;
            IsAuthenticated = !string.IsNullOrEmpty(email);
        }
    }
}
