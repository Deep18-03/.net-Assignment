using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Repository
{
    public interface IVehicleRepository
    {
        List<VehicleVM> getAllVehicle();
        VehicleVM getVehicleById(int Id);
        string updateVehicle(VehicleVM model);
        string deleteVehicle(int Id);
        string addVehicle(VehicleVM model);
    }
}
