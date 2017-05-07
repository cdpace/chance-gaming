using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Infrastructure.Abstract.DAL
{
    public class FilterValue<T>
    {
        public string PropertyName { get; set; }
        public T Value { get; set; }
    }
}
