using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.BAL.Interface
{
    public interface ICustomerManager
    {
        List<CustomerVM> getAllCustomer();
        CustomerVM getCustomerbyId(int Id);

        string updateCustomer(int id, CustomerVM model);
        string deleteCustomer(int Id);
        string createCustomer(CustomerVM model);

    }
}
