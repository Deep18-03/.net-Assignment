using AutoMapper;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Database.SBSDBEntities _dbContext;

        public UserRepository()
        {
            _dbContext = new Database.SBSDBEntities();
        }
        public List<string> AuthenticateUser(Customer model)
        {
            var entity = _dbContext.Customers.Where(x => x.EmailId.Equals(model.EmailId) && x.Password.Equals(model.Password)).FirstOrDefault();//Finds User
            List<string> session = new List<string>();
            if (entity != null)//If User Exist
            {
                session.Add(entity.Name);
                session.Add(entity.id.ToString());
                return session;//Return List Of String
            }
            session.Add("Not Found");
            return session;//Not Found
        }
        //Create new user. Accept Userdata type as argument. Return List of string which includes name and id.
        public List<string> CreateUser(Customer model)
        {
            List<string> session = null;
            try
            {
                if (model != null)
                {
                    session = new List<string>();
                    Database.Customer entity = new Database.Customer();
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, Database.Customer>());
                    var Mapper = new Mapper(config);
                    entity = Mapper.Map<Database.Customer>(model);//Mapper map type UserData to Database.UserData
                    _dbContext.Customers.Add(entity);//Add User Data
                    _dbContext.SaveChanges();
                    session.Add(entity.Name);
                    session.Add(entity.id.ToString());
                    return session;//Return List Of String
                }
                return session;//If model is null
            }
            catch (Exception ex)
            {
                return session;
            }
        }
    }
}
