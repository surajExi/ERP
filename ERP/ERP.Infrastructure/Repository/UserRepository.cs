using ERP.Core.Data;
using ERP.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public VW_UserDetails GetUserDetails()
        {
            VW_UserDetails vw = new VW_UserDetails();
            using(var entities = new ERPEntities())
            {
               
            }
            return vw;
        }
    }
}
