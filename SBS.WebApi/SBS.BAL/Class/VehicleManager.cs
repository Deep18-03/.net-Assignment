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
    public class VehicleManager:IVehicleManager
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleManager(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public string addVehicle(VehicleVM model)
        {
            return _vehicleRepository.addVehicle(model);
        }

        public string deleteVehicle(int Id)
        {
            return _vehicleRepository.deleteVehicle(Id);
        }

        public List<VehicleVM> getAllVehicle()
        {
            return _vehicleRepository.getAllVehicle();
        }

        public VehicleVM getVehicleById(int Id)
        {
            return _vehicleRepository.getVehicleById(Id);
        }

        public string updateVehicle(VehicleVM model)
        {
            return _vehicleRepository.updateVehicle(model);
        }
    }
}
