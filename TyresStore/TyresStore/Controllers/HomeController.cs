using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TyresStore.Repository;
using TyresStore.Repository.Models;

namespace TyresStore.Controllers
{
    public class HomeController : Controller
    {

        VehiclesRepository vehiclesRepository = new VehiclesRepository();
        TyresRepository tyresRepository = new TyresRepository();

        public ActionResult Index()
        {
            List<Vehicle> vehicles = vehiclesRepository.getVehicles();
            return View(vehicles);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            TyresStoreContext t = new TyresStoreContext();
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}