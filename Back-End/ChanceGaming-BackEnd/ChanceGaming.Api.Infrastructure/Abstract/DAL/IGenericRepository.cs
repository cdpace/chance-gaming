using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Infrastructure.Abstract.DAL
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> Get(params FilterValue<object>[] filters);
    }
}
