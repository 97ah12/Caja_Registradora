using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Registradora.Models
{
    public partial class ClosedSaleBox
    {
        public string Date { get; set; }
        public int TotalSales { get; set; }
        public float TotalCash { get; set; }
    }
}
