using SBS.BAL.Class;
using SBS.BAL.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using SBS.BAL.UnityHelper;

namespace ServiceBookingSystem
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICustomerManager, CustomerManager>();
            container.RegisterType<IMechanicmanager, MechanicManager>();
            container.RegisterType<IDealerManager, DealerManager>();
            container.RegisterType<IVehicleManager, VehicleManager>();
            container.AddNewExtension<UnityHelperRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}