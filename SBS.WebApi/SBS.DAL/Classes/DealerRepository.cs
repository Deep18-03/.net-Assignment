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
    public class DealerRepository:IDealerRepository
    {

        private readonly Database.ServiceBookingSystemEntities _dbContext;
        public DealerRepository()
        {
            _dbContext = new Database.ServiceBookingSystemEntities();
        }
        public string createDealer(DealerVM model)
        {
            if (model != null)
            {
                Database.Dealer dealer = new Database.Dealer();
                dealer.Name = model.Name;
                dealer.Mobile = model.Mobile;
                dealer.Address = model.Address;
                //dealer.Locality = model.Locality;
                dealer.Zipcode = model.Zipcode;
                dealer.Email = model.Email;
                _dbContext.Dealers.Add(dealer);
                _dbContext.SaveChanges();
                return "";
            }
            return "";
        }

        public string deleteDealer(int Id)
        {
            var entity = _dbContext.Dealers.Find(Id);
            if (entity != null)
            {
                var entities = _dbContext.Entry(entity);
                entities.State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return "";
            }
            return "";
        }

        public List<DealerVM> getAllDealer()
        {
            var entities = _dbContext.Dealers.ToList();
            List<DealerVM> dealerdata = new List<DealerVM>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
                    DealerVM model = new DealerVM();
                    model.Name = item.Name;
                    model.Mobile = item.Mobile;
                    model.Address = item.Address;
                    //dealer.Locality = model.Locality;
                    model.Zipcode = item.Zipcode;
                    model.Email = item.Email;
                    dealerdata.Add(model);
                }
            }
            return dealerdata;
        }

        public DealerVM getDealerById(int Id)
        {
            var entity = _dbContext.Dealers.Find(Id);
            DealerVM model = new DealerVM();
            if (entity != null)
            {
                model.Name = entity.Name;
                model.Mobile = entity.Mobile;
                model.Address = entity.Address;
                model.Zipcode = entity.Zipcode;
                model.Email = entity.Email;
            }
            return model;
        }

        public string updateDealer(DealerVM model)
        {
            var entity = _dbContext.Dealers.Find(model.Id);
            if (model != null)
            {
                entity.Name = model.Name;
                entity.Mobile = model.Mobile;
                entity.Address = model.Address;
                entity.Zipcode = model.Zipcode;
                entity.Email = model.Email;
                _dbContext.SaveChanges();
            }
            return entity.ToString();
        }
    }
}
