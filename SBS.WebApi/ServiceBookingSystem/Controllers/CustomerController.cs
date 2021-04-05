using SBS.BAL.Interface;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiceBookingSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerManager _customermanager;

        public CustomerController(ICustomerManager customermanager)
        {
            _customermanager = customermanager;
        }
        // GET: Customer
        public ActionResult Index()
        {
            List<CustomerVM> li = _customermanager.getAllCustomer();
            if (li != null)
            {
                return View(li);
            }
            return View();
        }
    }
}