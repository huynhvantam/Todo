using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Web.Models;
using Todo.Web.Models.demo;
using Todo.Web.Models.Todo;

namespace Todo.Web.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {



            return View();
        }




    }
}


