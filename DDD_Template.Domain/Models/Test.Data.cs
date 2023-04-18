using DDD_Template.Domain.Common;
using System;
using System.Collections.Generic;

namespace DDD_Template.Domain.Models
{
    public class TestData : IInitialData
    {
        public Type EntityType => typeof(Test);

        public IEnumerable<object> GetData() =>
            new List<Test>()
            {
                new Test("Atanas Vasilev")
            };
    }
}
