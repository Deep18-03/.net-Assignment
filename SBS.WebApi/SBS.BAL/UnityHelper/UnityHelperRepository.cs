using SBS.DAL.Classes;
using SBS.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Extension;
using Unity;

namespace SBS.BAL.UnityHelper
{
    public class UnityHelperRepository: UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ICustomerRepository, CustomerRepository>();
            Container.RegisterType<IMechanicRepository, MechanicRepositoy>();
            Container.RegisterType<IVehicleRepository, VehicleRepository>();
            Container.RegisterType<IDealerRepository, DealerRepository>();
            
        }
    }
}
