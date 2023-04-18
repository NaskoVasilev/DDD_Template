using System;
using System.Collections.Generic;

namespace DDD_Template.Domain.Common
{
    public interface IInitialData
    {
        public Type EntityType { get; }

        public IEnumerable<object> GetData();
    }
}
