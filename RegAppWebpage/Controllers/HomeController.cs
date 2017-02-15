using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University;
using University.Users;

namespace RegAppWebpage.Controllers
{
    public class HomeController : Controller
    {
        Student stevo = new Student("Stephen", "Kirkland", "password", "sk01417@uga.edu", 1, "CSEE");

        // GET: Home
        public ViewResult Students()
        {
            return View(stevo);
        }
    }
}