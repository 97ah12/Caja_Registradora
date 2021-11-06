using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Registradora.Models
{
    public class Sale
    {
        public int SaleCode { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public float TotalSale { get; set; }
        public bool IsCorrect { get; set; }
    }
}
