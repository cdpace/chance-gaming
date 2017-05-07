using ChanceGaming.Api.Infrastructure.Abstract.DAL;
using ChanceGaming.Api.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Infrastructure.DAL
{
    public class GenericMemoryRepository<TEntity> : IGenericRepository<TEntity> where TEntity :class
    {
        public IEnumerable<TEntity> Get(params FilterValue<object>[] filters)
        {
            throw new NotImplementedException();
        }
    }
}
