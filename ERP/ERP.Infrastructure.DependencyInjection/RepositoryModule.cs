using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Core.Interfaces.Repository;
using Ninject.Modules;
using ERP.Infrastructure.Repository;

namespace ERP.Infrastructure.DependencyInjection
{
    public class RepositoryModule :NinjectModule
    {
        public override void Load()
        {
            // TO DO BINDINGS..
            Bind<IDemoInterfaceRepository>().To<DemoInterfaceImplementationRepository>();
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
