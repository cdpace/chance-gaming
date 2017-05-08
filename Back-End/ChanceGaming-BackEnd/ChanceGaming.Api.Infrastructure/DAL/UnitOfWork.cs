using ChanceGaming.Api.Infrastructure.Abstract.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Infrastructure.DAL
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        public UnitOfWork()
        {

        }

        
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get<TEntity>(params FilterValue<object>[] filters)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
