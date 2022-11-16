using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentProgressReportSystem.Controllers
{
    public class ClassController : Controller
    {
        // GET: /<controller>/
        public ViewResult List()
        {
            return View();
        }
        public ViewResult Add()
        {
            return View();
        }
    }
}

