using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Interfaces;
using TyresStore.Repository.Models;

namespace TyresStore.Repository
{
    public class BasketRepository : IBasketRepository
    {
        TyresStoreContext DbContext = new TyresStoreContext();
        TyresRepository tr = new TyresRepository();

        public void adaugaCantitate(int tyreID)
        {
            var item = DbContext.BasketItems.SingleOrDefault(x => x.TyreId == tyreID);
            item.cant++;
            DbContext.SaveChanges();
        }

        public List<Basket> getItems()
        {
            return DbContext.BasketItems.ToList();
        }

        public void removeItem(int itemId)
        {
            var item = DbContext.BasketItems.SingleOrDefault(x => x.TyreId == itemId);
            DbContext.BasketItems.Remove(item);
            DbContext.SaveChanges();
        }

        public void stergeCantitate(int tyreID)
        {
            var item = DbContext.BasketItems.SingleOrDefault(x => x.TyreId == tyreID);
            if (item.cant > 1)
                item.cant--;
            else
                this.removeItem(tyreID);
            DbContext.SaveChanges();
        }

        public void stergeTot()
        {
            List<Basket> list = this.getItems();
            DbContext.BasketItems.RemoveRange(list);
            DbContext.SaveChanges();
        }

        public void StoreTyre(int tyreID, string description)
        {
            Tyre tyre=tr.GetTyreById(tyreID);
            Basket item = new Basket();
            item.pret =(int) tyre.Price;
            item.TyreId = tyreID;
            item.Description = description;
            item.cant = 1;
            item.AddedDate = new DateTime().ToShortDateString() + new DateTime().ToShortTimeString();
            DbContext.BasketItems.Add(item);
            DbContext.SaveChanges();
            
            
        }

        public bool typeAlreadyAdded(int tyreID)
        {
            List<Basket> items = this.getItems();
            var item = items.FirstOrDefault(x => x.TyreId == tyreID);
            return item != null;
        }
    }
}
