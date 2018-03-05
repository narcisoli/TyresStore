using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Interfaces;
using TyresStore.Repository.Models;

namespace TyresStore.Repository
{
    public class TyresRepository : ITyresRepository
    {

        TyresStoreContext tyres = new TyresStoreContext();
        public Tyre GetTyreById(int tyreid)
        {
            return tyres.Tyres.FirstOrDefault(x => x.ID == tyreid);
        }

        public List<Tyre> GetTyres()
        {

            return tyres.Tyres.ToList();
        }

        public List<Tyre> GetTyresByVehicleId(int vehicleID)
        {
            return tyres.Tyres.Where(x => x.VehicleId == vehicleID).ToList();

        }
    }
}
