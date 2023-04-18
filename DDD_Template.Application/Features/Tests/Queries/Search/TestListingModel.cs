using DDD_Template.Application.Mapping;
using DDD_Template.Domain.Models;

namespace DDD_Template.Application.Features.Tests.Queries.Search
{
    public class TestListingModel : IMapFrom<Test>
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = default!;
    }
}
