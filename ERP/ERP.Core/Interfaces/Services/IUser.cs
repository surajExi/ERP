using ERP.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Interfaces.Services
{
    public interface IUser
    {
        VW_UserDetails GetUserDetails();
    }
}
