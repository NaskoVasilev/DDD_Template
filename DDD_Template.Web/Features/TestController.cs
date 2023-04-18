using DDD_Template.Application.Features.Tests.Queries.Search;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DDD_Template.Web.Features
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<SearchTestsOutputModel>> Get([FromQuery] SearchTestsQuery query) =>
            await this.Mediator.Send(query);
    }
}
