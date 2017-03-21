using ERP.Core.Data;
using ERP.Core.Interfaces.Repository;
using ERP.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Infrastructure.Services
{
    public class UserService : IUser
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public VW_UserDetails GetUserDetails()
        {
            return _userRepository.GetUserDetails();
        }
    }
}
