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
        List<BasketObject> bucketlist;

        VehiclesRepository vehiclesRepository = new VehiclesRepository();
        TyresRepository tyresRepository = new TyresRepository();
        BasketRepository basketRepository = new BasketRepository();

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

        public ActionResult AddTyreToBasket(int tyreID,string description)
        {
            bool tyreAdded = basketRepository.typeAlreadyAdded(tyreID);
            if (!tyreAdded) basketRepository.StoreTyre(tyreID, description);
            return Json(new { exist = tyreAdded });
        }
        public ActionResult StergeTot()
        {
           
            basketRepository.stergeTot();
            return Json(new { exist = true });
        }

        public string GetBasketHTML()
        {
            List<Basket> list = basketRepository.getItems();
            string ret = RenderPartialViewToString("~/Views/Home/basketView.cshtml", list);
            return ret;
        }

        public ActionResult StergeItem(int tyreid)
        {
            basketRepository.removeItem(tyreid);
            return Json(new { exist = true });
        }

        public ActionResult AdaugaCantitate(int tyreid)
        {
            basketRepository.adaugaCantitate(tyreid);
            return Json(new { exist = true });
        }

        public ActionResult StergeCantitate(int tyreid)
        {
            basketRepository.stergeCantitate(tyreid);
            return Json(new { exist = true });
        }


        /*public string updateBucket(int tyreId)
        {
            
            Tyre tyre = tyresRepository.GetTyreById(tyreId);

            bucketlist=StaticList.getList();
            bool nou= true;
            foreach(BasketObject item in bucketlist)
            {
                if (item.tyre.ID == tyreId)
                {
                    item.cant++;
                    nou = false;
                }
            }
            if(nou)
            bucketlist.Add(new BasketObject(tyre,1));

            string res = RenderPartialViewToString("~/Views/Home/bucketView.cshtml", bucketlist);
            return res;
            
        }*/


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