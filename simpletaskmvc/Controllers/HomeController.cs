using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using simpletaskmvc.DAL;
using simpletaskmvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace simpletaskmvc.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
