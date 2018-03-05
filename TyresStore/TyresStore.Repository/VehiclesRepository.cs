using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Interfaces;
using TyresStore.Repository.Models;

namespace TyresStore.Repository
{
    public class VehiclesRepository : IVehiclesRepository
    {
        TyresStoreContext tyresContext = new TyresStoreContext();
        public Vehicle GetVehicleById(int vehicleId)
        {
            return tyresContext.Vehicles.FirstOrDefault(x => x.ID == vehicleId);
        }

        public List<Vehicle> getVehicles()
        {
           return tyresContext.Vehicles.ToList();
        }
    }
}
