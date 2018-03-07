using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TyresStore.Repository.Models;

namespace TyresStore
{
    public  class StaticList
    {
        private static List<BasketObject> list;

        public static List<BasketObject> getList()
        {
            if (list == null)
                list = new List<BasketObject>();
            return list;
        }
        
        
    }
}