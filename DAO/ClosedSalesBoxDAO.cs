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
    public class ClosedSalesBoxDAO
    {
        List<ClosedSaleBox> _closeSaleList;
        List<Sale> _sales;
        ClosedSaleBox _closedSale;
        public ClosedSalesBoxDAO()
        {
            _closeSaleList = new();
            _sales = new();
        }

        public List<ClosedSaleBox> GetClosedSalesBox()
        {
            FillClosedSalesList();
            return _closeSaleList;
        }

        public void GenerateCloseSale(List<Sale> sales)
        {
            _sales = sales.FindAll(s => s.SaleDate == DateTime.Now.ToShortDateString());
            FillClosedSalesList();
            _closedSale = new();
            _closedSale.Date = _sales[0].SaleDate;
            _closedSale.TotalSales = _sales.Count;
            foreach (var item in _sales)
            {
                //Asignacion Compuesta
                _closedSale.TotalCash += item.TotalSale;
            }
            _closeSaleList.Add(_closedSale);
            WriteOnFile(_closeSaleList);
        }

        private void FillClosedSalesList()
        {
            //Llamamos la clase TextReader que nos permite escribir archivos de Texto
            TextReader reader;
            //Instanciamos la clase StreamReader para que lea dentro de Productos.Json nuestra lista _salesList
            using (reader = new StreamReader(@"ClosedSales.json"))
            {
                //Aqui deserializamos la lista para poder ver el archivo
                var deserializedClosedSales = JsonConvert.DeserializeObject<List<ClosedSaleBox>>(reader.ReadToEnd());
                //Igualamos _salesList cn la lista ya deserialzada para poder  leer el archivo.
                _closeSaleList = deserializedClosedSales;
                //Aqui se cierra la lectura del archivo
                reader.Close();
            }
        }

        public static void WriteOnFile(List<ClosedSaleBox> closedSales)
        {
            //Llamamos TextWriter que nos permite escrbir en nuestra carpeta Products.Json
            TextWriter writer;
            //Instanciamos StreamWriter que nos permite ya como tal escrbir el archivo texto en _salesList
            using (writer = new StreamWriter(@"ClosedSales.json", append: false))
            {
                //Aqui se serializa la lista para poder escribir el archivo
                var serializedProduct = JsonConvert.SerializeObject(closedSales);
                //Aqui la lista se pasa a texto (string)
                writer.WriteLine(serializedProduct);
                //Se cierra la escritura del archivo
                writer.Close();
            }
        }
    }
}
