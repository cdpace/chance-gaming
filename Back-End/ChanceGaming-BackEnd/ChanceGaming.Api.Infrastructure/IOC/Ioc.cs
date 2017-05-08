using System;
using System.Collections.Generic;
using System.Text;
using StructureMap;
using ChanceGaming.Api.Model.Entities.Games;
using ChanceGaming.Api.Infrastructure.Abstract.DAL;
using ChanceGaming.Api.Infrastructure.DAL;

namespace ChanceGaming.Api.Infrastructure.IOC
{
    public static class Ioc
    {
        private static Container _Container = null;

        private static void InitContainer()
        {
            var repositoryRegistry = new Registry();
            //DAL Registries
            repositoryRegistry.ForSingletonOf<IGenericRepository<TimedBet>>().Use<GenericMemoryRepository<TimedBet>>();

            var utilsRegistry = new Registry();
            utilsRegistry.For<IUnitOfWork>().Use<UnitOfWork>();

            //Configure the container
            _Container = new Container();
            _Container.Configure(x => {
                x.AddRegistry(repositoryRegistry);
            });
        }

        public static Container Conatiner
        {
            get
            {
                if (_Container == null)
                    InitContainer();

                return _Container;
            }
        }

    }
}
