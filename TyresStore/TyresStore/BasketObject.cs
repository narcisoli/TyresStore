using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TyresStore.Repository.Models;

namespace TyresStore
{
    public class BasketObject
    {
        public Tyre tyre { get; set; }
        public int cant { get; set; }
        public BasketObject(Tyre t,int c)
        {
            this.tyre = t;
            this.cant = c;
        }
    }
}