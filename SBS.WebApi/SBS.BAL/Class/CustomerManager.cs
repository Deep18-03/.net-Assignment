using SBS.BAL.Interface;
using SBS.DAL.Repository;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.BAL.Class
{
    public class CustomerManager: ICustomerManager
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public string createCustomer(CustomerVM model)
        {
            return _customerRepository.createCustomer(model);
        }

        public string deleteCustomer(int Id)
        {
            return _customerRepository.deleteCustomer(Id);
        }

        public List<CustomerVM> getAllCustomer()
        {
            return _customerRepository.getAllCustomer();
        }

        public CustomerVM getCustomerbyId(int id)
        {
            return _customerRepository.getCustomerbyId(id);
        }

        public string updateCustomer(int id, CustomerVM model)
        {
            return _customerRepository.updateCustomer(id, model);
        }



    
    }
}
