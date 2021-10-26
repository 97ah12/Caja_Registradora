using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Registradora.Models
{
    public partial class Product
    {
        public string Code { get; set;}
        public string Description{ get; set;}
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
