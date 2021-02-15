using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Repository
{
     public interface IUserRepository
    {
        List<string> AuthenticateUser(Customer model);
        List<string> CreateUser(Customer model);
    }
}
