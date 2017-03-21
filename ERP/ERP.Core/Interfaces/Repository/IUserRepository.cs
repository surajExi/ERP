using ERP.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Interfaces.Repository
{
   public interface IUserRepository
    {
        VW_UserDetails GetUserDetails();
    }
}
