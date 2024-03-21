using CP1_Alysson_Pinheiro_RM550837.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CP1_Alysson_Pinheiro_RM550837.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
    }
}
