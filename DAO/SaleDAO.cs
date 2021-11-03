using Caja_Registradora.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Registradora.DAO
{
    public class SaleDAO
    {
        List<Sale> _salesList;
        public SaleDAO()
        {
            _salesList = new();
        }

        public List<Sale> GetSalesList()
        {
            //FillSalesList();
            return _salesList;
        }

        public void SaleProduct(Sale sale)
        {
            _salesList.Add(sale);
            WriteOnFile(_salesList);
        }

        private void FillSalesList()
        {
            TextReader reader;
            using (reader = new StreamReader(@"Sales.json"))
            {
                var deserializedSales = JsonConvert.DeserializeObject<List<Sale>>(reader.ReadToEnd());
                _salesList = deserializedSales;
                reader.Close();
            }
        }

        public static void WriteOnFile(List<Sale> sales)
        {
            TextWriter writer;
            using (writer = new StreamWriter(@"Sales.json", append: false))
            {
                var serializedProduct = JsonConvert.SerializeObject(sales);
                writer.WriteLine(serializedProduct);
                writer.Close();
            }
        }
    }
}
