using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Core.Interfaces.Repository;

namespace ERP.Infrastructure.Repository
{
   public class DemoInterfaceImplementationRepository:IDemoInterfaceRepository
    {
       public string GetMessage()
       {
           return this.ToString();
       }
    }
}
