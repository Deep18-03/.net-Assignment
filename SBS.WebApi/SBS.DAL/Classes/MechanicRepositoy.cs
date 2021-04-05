using SBS.DAL.Repository;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Classes
{
    public class MechanicRepositoy:IMechanicRepository
    {

        private readonly Database.ServiceBookingSystemEntities _dbContext;
        public MechanicRepositoy()
        {
            _dbContext = new Database.ServiceBookingSystemEntities();
        }
        public string createMechanic(MechanicVM model)
        {
            try
            {
                if (model != null)
                {
                    Database.Mechanic mechanicdetail = new Database.Mechanic();

                    mechanicdetail.Name = model.Name;
                    mechanicdetail.Mobile = model.Mobile;
                    mechanicdetail.EmailId = model.EmailId;
                    _dbContext.Mechanics.Add(mechanicdetail);
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

        public string deleteMechanic(int Id)
        {
            var entity = _dbContext.Mechanics.Find(Id);
            if (entity != null)
            {
                var entities = _dbContext.Entry(entity);
                entities.State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return "";
            }
            return "";
        }

        public List<MechanicVM> getallMechanic()
        {
            var entities = _dbContext.Mechanics.ToList();
            List<MechanicVM> mechanicdata = new List<MechanicVM>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
                    MechanicVM mechanicmodels = new MechanicVM();
                    mechanicmodels.Id = item.Id;
                    mechanicmodels.Name = item.Name;
                    mechanicmodels.Mobile = item.Mobile;
                    mechanicmodels.EmailId = item.EmailId;
                    mechanicdata.Add(mechanicmodels);
                }
            }
            return mechanicdata;
        }

        public MechanicVM getMechanicyId(int Id)
        {
            var entity = _dbContext.Mechanics.Find(Id);
            MechanicVM model = new MechanicVM();
            if (entity != null)
            {
                model.Id = entity.Id;
                model.Name = entity.Name;
                model.Mobile = entity.Mobile;
                model.EmailId = entity.EmailId;

            }
            return model;
        }

        public string updateMechanic(MechanicVM model)
        {
            var entity = _dbContext.Mechanics.Find(model.Id);
            if (model != null)
            {
                entity.Name = model.Name;
                entity.Mobile = model.Mobile;
                entity.EmailId = model.EmailId;
                _dbContext.SaveChanges();
            }
            return entity.ToString();
        }
    }
}
