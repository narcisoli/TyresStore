using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Models;

namespace TyresStore.Repository.Interfaces
{
   public interface IVehiclesRepository
    {
        Vehicle GetVehicleById(int id);
        List<Vehicle> getVehicles();
    }
}
