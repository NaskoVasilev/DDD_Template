using Microsoft.AspNetCore.Identity;

namespace DDD_Template.Infrastructure.Identity
{
    public class User : IdentityUser
    {
        internal User(string email) : base(email)
        {
        }
    }
}
