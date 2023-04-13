using DDD_Template.Domain.Models;

namespace DDD_Template.Domain.Factories.Tests
{
    public interface ITestFactory : IFactory<Test>
    {
        ITestFactory WithName(string name);
    }
}
