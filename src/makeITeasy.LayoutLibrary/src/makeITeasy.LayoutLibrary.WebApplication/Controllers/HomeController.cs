using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using makeITeasy.LayoutLibrary.Template.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace makeITeasy.LayoutLibrary.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly PageDefinition pageDefinition;

        public HomeController(PageDefinition pageDefinition)
        {
            this.pageDefinition = pageDefinition;
        }

        public IActionResult Index()
        {
            pageDefinition.Title = "My Index Page";
            return View();
        }
    }
}
