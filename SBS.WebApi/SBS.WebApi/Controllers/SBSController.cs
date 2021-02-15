using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SBS.WebApi.Controllers
{
    public class SBSController : Controller
    {
        private readonly HttpClient _client;

        public SBSController()
        {
            _client = new HttpClient();
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Customer model)
        {
            var task = _client.PostAsJsonAsync<Customer>("https://localhost:44399/api/Customer/PostAuthenticateUser/", model);
            task.Wait();

            var result = task.Result.Content.ReadAsAsync<List<String>>();
            result.Wait();

            var check = result.Result;
            if (check != null)
            {
                HttpContext.Session.Add("userName", check[0]);
                HttpContext.Session.Add("id", check[1]);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["LoginMessage"] = "Email Or Password Is Wrong!";
            }
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}