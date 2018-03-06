using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using TyresStore.Models;
using TyresStore.Repository;
using TyresStore.Repository.Models;

namespace TyresStore.Controllers
{
    public class HomeController : Controller
    {
        List<Tyre> bucketlist = new List<Tyre>();

        VehiclesRepository vehiclesRepository = new VehiclesRepository();
        TyresRepository tyresRepository = new TyresRepository();

        public ActionResult Index()
        {
            List<Vehicle> vehicles = vehiclesRepository.getVehicles();
            List<Tyre> tyres = tyresRepository.GetTyres();
            Model a = Model.getIntance(vehicles,tyres);
        
            return View(a);
        
    }

        public string getTyres(int vecID)
        {
            List<Tyre> tyres = tyresRepository.GetTyresByVehicleId(vecID);
            string ret = RenderPartialViewToString("~/Views/Home/TyresView.cshtml", tyres);
            return ret;
        }

        public string updateBucket(int tyreId)
        {
            
            Tyre tyre = tyresRepository.GetTyreById(tyreId);
           
            bucketlist.Add(tyre);
            string res = RenderPartialViewToString("~/Views/Home/bucketView.cshtml", bucketlist);
            return res;
            
        }


        public string RenderPartialViewToString(string viewName, object model)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.RouteData.GetRequiredString("action");

            ViewData.Model = model;

            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);

                return sw.GetStringBuilder().ToString();
            }
        }
    }
}