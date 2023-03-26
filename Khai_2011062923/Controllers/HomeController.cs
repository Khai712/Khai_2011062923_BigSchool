using Khai_2011062923.Models;
using Khai_2011062923.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Khai_2011062923.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcomingCouress = _dbContext.Courses

                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.Datetime > DateTime.Now);
            var viewModel = new CourseViewModel
            {

                UpcommingCourses = upcomingCouress,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);

        }
    
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}