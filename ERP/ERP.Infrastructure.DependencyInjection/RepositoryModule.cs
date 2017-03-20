using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Core.Interfaces.Repository;
using ERP.Infrastructure.Repository;
using Ninject.Modules;

namespace ERP.Infrastructure.DependencyInjection
{
    public class RepositoryModule :NinjectModule
    {
        public override void Load()
        {
            // TO DO BINDINGS..
            Bind<IDemoInterfaceRepository>().To<DemoInterfaceImplementationRepository>();
        }
    }
}
