using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyresStore.Repository.Models
{
    public class Basket
    {
        [Key]
        public int ID { get; set; }
        public int TyreId { get; set; }
        public string Description { get; set; }
        public string AddedDate { get; set; }
        public int cant { get; set; }
        public int pret { get; set; }

    }
}
