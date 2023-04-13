using DDD_Template.Application.Contracts;
using DDD_Template.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DDD_Template.Web.Features
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IRepository<Test> tests;

        public TestController(IRepository<Test> tests) => this.tests = tests;

        [HttpGet]
        public IEnumerable<Test> Get() => this.tests.All().ToList();
    }
}
