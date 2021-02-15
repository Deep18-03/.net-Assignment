using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Models;



namespace SBS.BAL.Interface
{
    public interface IUserManager
    {
        List<string> AuthenticateCustomer(Customer model);
        List<string> CreateCustomer(Customer model);
    }
}
