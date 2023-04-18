using DDD_Template.Application.Common;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using DDD_Template.Application.Contracts;

namespace DDD_Template.Application.Features.Identity.Commands.CreateUser
{
    public class CreateUserCommand : UserInputModel, IRequest<Result>
    {
        public CreateUserCommand(string email, string password)
            : base(email, password)
        {
        }

        public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result>
        {
            private readonly IIdentity identity;

            public CreateUserCommandHandler(IIdentity identity) => this.identity = identity;

            public Task<Result> Handle(
                CreateUserCommand request,
                CancellationToken cancellationToken)
                => this.identity.Register(request);
        }
    }
}
