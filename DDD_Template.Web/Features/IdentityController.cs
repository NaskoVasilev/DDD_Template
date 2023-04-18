using DDD_Template.Application.Contracts;
using DDD_Template.Application.Features.Identity;
using DDD_Template.Application.Features.Identity.Commands.CreateUser;
using DDD_Template.Application.Features.Identity.Commands.LoginUser;
using DDD_Template.Web.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DDD_Template.Web.Features
{
    [ApiController]
    [Route("[controller]")]
    public class IdentityController : ApiController
    {
        private readonly IIdentity identity;

        public IdentityController(IIdentity identity) => this.identity = identity;

        [HttpPost]
        [Route(nameof(Register))]
        public async Task<ActionResult> Register(UserInputModel model)
        {
            var result = await this.identity.Register(model);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok();
        }

        [HttpPost]
        [Route(nameof(Register))]
        public async Task<ActionResult> Register(CreateUserCommand command)
            => await this.Send(command);

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<ActionResult<LoginOutputModel>> Login(LoginUserCommand command) =>
            await this.Send(command);
    }
}
