using SBS.BAL.Interface;
using SBS.DAL.Repository;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.BAL
{
    public class UserManager:IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<string> AuthenticateCustomer(Customer model)
        {
            return _userRepository.AuthenticateUser(model);
        }

       

        public List<string> CreateCustomer(Customer model)
        {
            return _userRepository.CreateUser(model);
        }       
    }
}
