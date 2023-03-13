using LeQuocTrinh_2011063970.Models;
using LeQuocTrinh_2011063970.ViewModel;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeQuocTrinh_2011063970.Controllers
{

    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: Courses

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }


        [Authorize]
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