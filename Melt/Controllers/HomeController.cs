using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Melt.Models;
using Melt.Data;
using Melt.YodleeObjects;

namespace Melt.Controllers
{
    public class HomeController : Controller
    {
        private ISqlAccess access;

        public HomeController(ISqlAccess sqlAccess)
        {
            access = sqlAccess;
        }

        public IActionResult Index()
        {
            //string cobrandSessionId = YodleeAPICaller.CobrandLogin();
            //User user = YodleeAPICaller.UserLogin(cobrandSessionId);
            //// I don't want to talk about it. 
            //Account account = YodleeAPICaller.GetAccounts(cobrandSessionId, user.user.session.userSession);

            //Procs proc = new Procs(access);
            //proc.InsertUserAccount(account, user.user.id);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
