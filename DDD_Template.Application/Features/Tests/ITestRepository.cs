using DDD_Template.Application.Contracts;
using DDD_Template.Application.Features.Tests.Queries.Search;
using DDD_Template.Domain.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DDD_Template.Application.Features.Tests
{
    public interface ITestRepository : IRepository<Test>
    {
        Task<IEnumerable<TestListingModel>> GetTestsByName(string? name);

        Task<int> Count(CancellationToken cancellationToken);
    }
}
