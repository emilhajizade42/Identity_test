
using CRUD_pactice_1.DAL;
using CRUD_pactice_1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_pactice_1.Controllers
{
    public class HomeController : Controller
    {
      public AppDbContext _context { get; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel result = new HomeViewModel()
            {
                Cards = _context.Cards.ToList(),
            };
            return View(result);
        }

      
    }
}
