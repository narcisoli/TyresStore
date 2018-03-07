using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Models;

namespace TyresStore.Repository.Interfaces
{
    interface IBasketRepository
    {
        void StoreTyre(int tyreID, string description);
        List<Basket> getItems();
        bool typeAlreadyAdded(int tyreID);
        void removeItem(int itemId);
        void stergeTot();
        void adaugaCantitate(int tyreID);
        void stergeCantitate(int tyreID);

    }
}
