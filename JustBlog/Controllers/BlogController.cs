using JustBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustBlog.Controllers
{
    public class BlogController : Controller
    {
        public ViewResult Posts(int p =1)
        {
            var listViewModel = new ListViewModel();
            ViewBag.Title = "Latest Posts";
            return View("List", listViewModel);
        }
    }
}