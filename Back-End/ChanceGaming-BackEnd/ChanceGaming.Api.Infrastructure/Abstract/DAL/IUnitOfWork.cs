using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Infrastructure.Abstract.DAL
{
    public interface IUnitOfWork
    {
        void Save();
        IEnumerable<TEntity> Get<TEntity>(params FilterValue<object>[] filters);
    }
}
