using DDD_Template.Application.Common;
using DDD_Template.Application.Features.Identity;
using System.Threading.Tasks;

namespace DDD_Template.Application.Contracts
{
    public interface IIdentity
    {
        Task<Result> Register(UserInputModel input);

        Task<Result<LoginOutputModel>> Login(UserInputModel input);
    }
}
