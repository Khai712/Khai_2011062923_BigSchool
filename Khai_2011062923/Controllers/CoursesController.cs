using Khai_2011062923.Models;
using Khai_2011062923.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Khai_2011062923.Controllers
{
        public class CoursesController : Controller
        {
            private readonly ApplicationDbContext _dbContext;
            // GET: Courses
            public CoursesController()
            {
                _dbContext = new ApplicationDbContext();
            }
            public ActionResult Create()
            {
                var viewModel = new CourseViewModel
                {
                    Categories = _dbContext.Categories.ToList()
                };
                return View(viewModel);
            }


        }
    }