using GameApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            ViewModel view = new ViewModel();
            return View(view);

        }
        [HttpPost]
        public IActionResult Index(ViewModel model)
        {
            ServiceKPSTc serviceKPSTc = new ServiceKPSTc();
            Response  response = new Response();


            response._parameters.TCKimlikNo=model._parameters.TCKimlikNo;
            response._parameters.Ad=model._parameters.Ad;
            response._parameters.Soyad=model._parameters.Soyad;
            response._parameters.DogumYili=model._parameters.DogumYili;

            var result =serviceKPSTc.OnGetService(response._parameters);
            

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}