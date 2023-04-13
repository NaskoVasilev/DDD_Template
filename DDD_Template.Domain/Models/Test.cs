using DDD_Template.Domain.Common;

namespace DDD_Template.Domain.Models
{
    public class Test : IAggregateRoot
    {
        internal Test(string name)
        {
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; private set; }
    }
}
