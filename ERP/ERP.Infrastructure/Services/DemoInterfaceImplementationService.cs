using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Core.Interfaces;
using ERP.Core.Interfaces.Repository;

namespace ERP.Infrastructure.Services
{
   public class DemoInterfaceImplementationService:IDemoInterfaceService
    {
       private readonly IDemoInterfaceRepository _demoInterfaceRepository;

       public DemoInterfaceImplementationService(IDemoInterfaceRepository demoInterfaceRepository)
       {
           _demoInterfaceRepository = demoInterfaceRepository;
       }

       public string GetMessage()
       {
          return _demoInterfaceRepository.GetMessage();
       }
    }
}
