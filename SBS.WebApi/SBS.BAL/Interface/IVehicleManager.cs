using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.BAL.Interface
{
    public interface IVehicleManager
    {
        List<VehicleVM> getAllVehicle();
        VehicleVM getVehicleById(int Id);
        string updateVehicle(VehicleVM model);
        string deleteVehicle(int Id);
        string addVehicle(VehicleVM model);
    }
}
