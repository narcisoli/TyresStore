using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Models;

namespace TyresStore.Repository.Interfaces
{
    public interface ITyresRepository
    {
        Tyre GetTyreById(int tyreid);
        List<Tyre> GetTyres();
        List<Tyre> GetTyresByVehicleId(int vehicleID);

    }
}
