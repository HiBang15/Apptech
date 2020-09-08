using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using NetCore1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCore1.Controllers
{
    public class ExamsController : Controller
    {
        private DataContext db = new DataContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var exams = db.Exams.Include(e => e.Student).Include(e => e.Subject);
            return View();
        }
    }
}
