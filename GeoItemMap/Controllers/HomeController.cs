using GeoItemMap.DataBase;
using GeoItemMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GeoItemMap.DataBase.Entities;
using System.Web;


namespace GeoItemMap.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager, AppDbContext db)
        {
            this.dataManager = dataManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    

        [HttpPost]
        public async Task<JsonResult> PostData()
        {
            IEnumerable<GeoItem> geoItems = await dataManager.GeoItem.GetAllItem();
            GeoItemViewModel viewModel = new GeoItemViewModel { GeoItems = geoItems.ToList() };
            return Json(viewModel);
        }



        [HttpPost]
       public IActionResult Add (GeoItem model)
        {
            var random = new Random();
            double xDouble = Convert.ToDouble(random.Next(100) / 1.666);
            double yDouble = Convert.ToDouble(random.Next(100) / 1.666);
 
                model.X = xDouble;
                model.Y = yDouble;
                model.Description = "dDD";
                dataManager.GeoItem.SaveGeoItem(model);
            
            
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Del(GeoItem model)
        {

            dataManager.GeoItem.DeleteGeoItem(model.Id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Page2()
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
