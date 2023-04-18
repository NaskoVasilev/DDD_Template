using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DDD_Template.Application.Features.Tests.Queries.Search
{
    public class SearchTestsQuery : IRequest<SearchTestsOutputModel>
    {
        public string? Name { get; set; }

        public class SearchTestsQueryHanler : IRequestHandler<SearchTestsQuery, SearchTestsOutputModel>
        {
            private readonly ITestRepository testRepository;

            public SearchTestsQueryHanler(ITestRepository testRepository)
            {
                this.testRepository = testRepository;
            }

            public async Task<SearchTestsOutputModel> Handle(SearchTestsQuery request, CancellationToken cancellationToken)
            {
                return new SearchTestsOutputModel(
                    await this.testRepository.GetTestsByName(request.Name), 
                    await this.testRepository.Count(cancellationToken));
            }
        }
    }
}
