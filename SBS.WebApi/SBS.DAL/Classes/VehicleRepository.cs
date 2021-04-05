using SBS.DAL.Repository;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Classes
{
    public class VehicleRepository:IVehicleRepository
    {
        private readonly Database.ServiceBookingSystemEntities _dbcontext;
        public VehicleRepository()
        {
            _dbcontext = new Database.ServiceBookingSystemEntities();
        }
        public string addVehicle(VehicleVM model)
        {
            if (model != null)
            {
                Database.Vehicle vehicledetail = new Database.Vehicle();
                vehicledetail.LicensePlate = model.LicencePlate;
                vehicledetail.Make = model.Make;
                vehicledetail.Model = model.Model;
                vehicledetail.RegistrationDate = model.RegistrationDate;
                vehicledetail.ChassisNo = model.ChassisNo;
                
                vehicledetail.OwnerId = model.OwnerId;
                _dbcontext.Vehicles.Add(vehicledetail);
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public string deleteVehicle(int Id)
        {
            var entity = _dbcontext.Vehicles.Find(Id);
            if (entity != null)
            {
                var entities = _dbcontext.Entry(entity);
                entities.State = System.Data.Entity.EntityState.Deleted;
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public List<VehicleVM> getAllVehicle()
        {
            var entities = _dbcontext.Vehicles.ToList();
            List<VehicleVM> vehicles = new List<VehicleVM>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
                    VehicleVM vehicledata = new VehicleVM();
                    vehicledata.LicencePlate = item.LicensePlate;
                    vehicledata.Make = item.Make;
                    vehicledata.Model = item.Model;
                    vehicledata.RegistrationDate = item.RegistrationDate;
                    vehicledata.ChassisNo = item.ChassisNo;
                    vehicledata.OwnerId = item.OwnerId;
                    vehicles.Add(vehicledata);
                }
            }
            return vehicles;
        }

        public VehicleVM getVehicleById(int Id)
        {
            var entity = _dbcontext.Vehicles.Find(Id);
            VehicleVM model = new VehicleVM();
            if (entity != null)
            {
                model.LicencePlate = entity.LicensePlate;
                model.Make = entity.Make;
                model.RegistrationDate = entity.RegistrationDate;
                model.ChassisNo = entity.ChassisNo;
                model.OwnerId = entity.OwnerId;

            }
            return model;
        }

        public string updateVehicle(VehicleVM model)
        {
            var entity = _dbcontext.Vehicles.Find(model.Id);
            if (entity != null)
            {
                entity.LicensePlate = model.LicencePlate;
                entity.Make = model.Make;
                entity.RegistrationDate = model.RegistrationDate;
                entity.ChassisNo = model.ChassisNo;
                entity.OwnerId = model.OwnerId;
                _dbcontext.SaveChanges();
            }
            return entity.ToString();
        }
    }
}
