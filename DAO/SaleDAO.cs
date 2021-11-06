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
        //Creamos la lista _salesList
        List<Sale> _salesList;
        public SaleDAO()
        {
            //Instanciamos _salesList
            _salesList = new();
        }
        //Creamos el método GetSlesList que nos va a traer la Lista _salesList
        public List<Sale> GetSalesList()
        {
            //FillSalesList();
            return _salesList;
        }

        public void SaleProduct(Sale sale)
        {
            //Añadimos sale a nuestra lista _salesList
            _salesList.Add(sale);
            //Llamamos método WriteOnFile en _salesList para que la muestre serializada
            WriteOnFile(_salesList);
        }
        public List<Sale> GetSales()
        {
            FillSalesList();
            return _salesList;
        }
        //Creamos método FillSalesList para leer nuestros archivos de Texto en Products.Json

        private void FillSalesList()
        {
            //Llamamos la clase TextReader que nos permite escribir archivos de Texto
            TextReader reader;
            //Instanciamos la clase StreamReader para que lea dentro de Productos.Json nuestra lista _salesList
            using (reader = new StreamReader(@"Sales.json"))
            {
                //Aqui deserializamos la lista para poder ver el archivo
                var deserializedSales = JsonConvert.DeserializeObject<List<Sale>>(reader.ReadToEnd());
                //Igualamos _salesList cn la lista ya deserialzada para poder  leer el archivo.
                _salesList = deserializedSales;
                //Aqui se cierra la lectura del archivo
                reader.Close();
            }
        }
        //Llamamos método WriteOnFile para escribir los productos y añadirlos a la lista _salesList

        public static void WriteOnFile(List<Sale> sales)
        {
            //Llamamos TextWriter que nos permite escrbir en nuestra carpeta Products.Json
            TextWriter writer;
            //Instanciamos StreamWriter que nos permite ya como tal escrbir el archivo texto en _salesList
            using (writer = new StreamWriter(@"Sales.json", append: false))
            {
                //Aqui se serializa la lista para poder escribir el archivo
                var serializedProduct = JsonConvert.SerializeObject(sales);
                //Aqui la lista se pasa a texto (string)
                writer.WriteLine(serializedProduct);
            }
                //Se cierra la escritura del archivo
                writer.Close();
        }
    }
}
