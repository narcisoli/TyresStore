using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TyresStore.Repository.Models;

namespace TyresStore.Models
{
    public class Model
    {
        static Model instance;
        public List<Vehicle> vehicles { get; set; }
        public List<Tyre> tyres { get; set; }
        private Model(List<Vehicle> veh,List<Tyre> tyr)
        {
            this.vehicles = veh;
            this.tyres = tyr;
        }

        public static Model getIntance(List<Vehicle> veh, List<Tyre> tyr)
        {
            if (instance == null)
                instance = new Model(veh, tyr);
            return instance;
        }
    }
}