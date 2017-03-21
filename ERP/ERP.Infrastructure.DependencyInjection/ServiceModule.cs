using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Core.Interfaces;
using ERP.Infrastructure.Logging;
using ERP.Infrastructure.Services;
using Ninject.Modules;
using ERP.Core.Interfaces.Services;

namespace ERP.Infrastructure.DependencyInjection
{
   public class ServiceModule : NinjectModule
    {
       public override void Load()
       {
           //TO DO BINDINGS..
           Bind<IDemoInterfaceService>().To<DemoInterfaceImplementationService>();
           Bind<IUser>().To<UserService>();
       }
    }
}
