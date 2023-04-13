using DDD_Template.Domain.Models;

namespace DDD_Template.Domain.Factories.Tests
{
    internal class TestFactory : ITestFactory
    {
        private string name = default!;

        public Test Build() => new Test(this.name);

        public ITestFactory WithName(string name)
        {
            this.name = name;
            return this;
        }
    }
}
