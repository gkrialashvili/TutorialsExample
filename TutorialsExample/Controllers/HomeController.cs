using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorialsExample.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TutorialsExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;


        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;         
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            return View(pies);
        }
    }
}
