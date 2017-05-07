using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Model.Entities
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }

        public BaseEntity()
        {

        }
    }
}
