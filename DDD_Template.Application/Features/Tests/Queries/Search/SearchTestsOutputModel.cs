using System.Collections.Generic;
namespace DDD_Template.Application.Features.Tests.Queries.Search
{
    public class SearchTestsOutputModel
    {
        public SearchTestsOutputModel(IEnumerable<TestListingModel> tests, int total)
        {
            Tests = tests;
            Total = total;
        }

        public IEnumerable<TestListingModel> Tests  { get; set; }

        public int Total { get; set; }
    }
}
