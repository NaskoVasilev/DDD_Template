using DDD_Template.Application.Contracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;

namespace DDD_Template.Web.Services
{
    internal class CurrentUserService : ICurrentUser
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            var user = (httpContextAccessor.HttpContext?.User) ?? throw new InvalidOperationException("This request does not have an authenticated user.");
            this.UserId = user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public string UserId { get; }
    }
}
