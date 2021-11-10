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
        ProductDAO productDAO;
        public SaleDAO()
        {
            //Instanciamos _salesList
            _salesList = new();
            //
            productDAO = new();
        }
        //Creamos el método GetSlesList que nos va a traer la Lista _salesList
        public List<Sale> GetSalesList()
        {
            FillSalesList();
            return _salesList;
        }

        public void SaleProduct(Sale sale)
        {
            FillSalesList();
            //Añadimos sale a nuestra lista _salesList
            _salesList.Add(sale);
            //Acutaliza con el metodo UpdateSaledProduct lo que recibe como parametro desde la vista
            productDAO.UpdateSaledProduct(sale.ProductCode, sale.Quantity);
            //Llamamos método WriteOnFile en _salesList para que la muestre serializada
            WriteOnFile(_salesList);
        }
        //Creamos el metodo GetSales
        public List<Sale> GetSales()
        {
            //llamamos el metodo FillSalesList
            FillSalesList();
            return _salesList;
        }

        //Creamos el metodo GetSalesByDate
        public List<Sale> GetSalesByDate(DateTime date)
        {
            //Llamamos FillSalesList el cual nos deja leer nuestros archivos de Texto en Products
            FillSalesList();
            //Instanciamos salesFiltered
            List<Sale> salesFiltered = new();
            salesFiltered = _salesList;
            //Guardamos todos los elementos que hacen match con nuestro predicado en salesFiltered
            salesFiltered = salesFiltered.FindAll(s => s.SaleDate == date.ToShortDateString());
            return salesFiltered;
        }

        //Creamos método FillSalesList para leer nuestros archivos de Texto en Products.
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
                //Se cierra la escritura del archivo
                writer.Close();
            }
        }
    }
}


