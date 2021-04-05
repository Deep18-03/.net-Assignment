using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Repository
{
    public interface ICustomerRepository
    {
        List<CustomerVM> getAllCustomer();
        CustomerVM getCustomerbyId(int id);
        string updateCustomer(int id, CustomerVM model);
        string deleteCustomer(int Id);
        string createCustomer(CustomerVM model);
    }
}
