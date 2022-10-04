using CIS174AssignmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIS174AssignmentApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}