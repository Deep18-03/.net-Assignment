using SBS.DAL.Repository;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Classes
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly Database.ServiceBookingSystemEntities _dbContext;

        public CustomerRepository()
        {
            _dbContext = new Database.ServiceBookingSystemEntities();
        }


        public string createCustomer(CustomerVM model)
        {
            try
            {
                if (model != null)
                {
                    Database.Customer entity = new Database.Customer();
                    entity.Name = model.Name;
                    entity.Address = model.Address;
                    //entity.lo = model.Locality;
                    entity.EmailId = model.EmailId;
                    entity.MobileNo = model.MobileNo;
                    entity.City = model.City;
                    entity.State = model.State;
                    entity.Password = model.Password;
                    entity.Zipcode = model.Zipcode;
                    _dbContext.Customers.Add(entity);
                    _dbContext.SaveChanges();
                    return "";

                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return "";
        }

        public string deleteCustomer(int Id)
        {
            var entity = _dbContext.Customers.Find(Id);
            if (entity != null)
            {
                var entities = _dbContext.Entry(entity);
                entities.State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return "";
            }
            return "";
        }

        public List<CustomerVM> getAllCustomer()
        {

            var entities = _dbContext.Customers.ToList();
            List<CustomerVM> customerlist = new List<CustomerVM>();

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    CustomerVM customer = new CustomerVM();
                    customer.Name = item.Name;
                    customer.Address = item.Address;
                    //customer.Locality = item.Locality;
                    customer.EmailId = item.EmailId;
                    customer.MobileNo = item.MobileNo;
                    customer.City = item.City;
                    customer.State = item.State;
                    customer.Password = item.Password;
                    customer.Zipcode = item.Zipcode;
                    customerlist.Add(customer);
                }
            }
            return customerlist;
        }

        public CustomerVM getCustomerbyId(int id)
        {
            var entity = _dbContext.Customers.Find(id);
            CustomerVM customer = new CustomerVM();
            if (entity != null)
            {
                customer.Name = entity.Name;
                customer.Address = entity.Address;
                customer.EmailId = entity.EmailId;
                customer.MobileNo = entity.MobileNo;
                customer.City = entity.City;
                customer.State = entity.State;
                customer.Zipcode = entity.Zipcode;
                customer.Password = entity.Password;
            }
            return customer;
        }
        public string updateCustomer(int id, CustomerVM model)
        {
            var entity = _dbContext.Customers.Find(model.Id);
            if (model != null)
            {
                entity.Name = model.Name;
                entity.Address = model.Address;
                //entity.Locality = model.Locality;
                entity.EmailId = model.EmailId;
                entity.MobileNo = model.MobileNo;
                entity.City = model.City;
                entity.State = model.State;
                entity.Password = model.Password;
                entity.Zipcode = model.Zipcode;
                _dbContext.SaveChanges();

            }
            return entity.ToString();
        }
    }
}
