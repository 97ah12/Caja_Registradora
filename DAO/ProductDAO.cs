using Caja_Registradora.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Caja_Registradora.DAO
{
    public class ProductDAO
    {
        //Declaracion del modelo product
        Product _product;
        //Declaracion de la lista _productList
        List<Product> _productList;
        //Creo constructor
        public ProductDAO()
        {
            //Instancio la declaracion de _product
            _product = new();
            //Instancio la lista _productList
            _productList = new();
        }

        public void CreateProduct(Product product)
        {
            //Agrego el product enviado desde el DTO a la Lista Global
            _productList.Add(product);
            WriteOnFile(_productList);
        }

        public List<Product> GetProductList()
        {
            // retorna la lista de productos Global
            FillProductList();
            return _productList;
        }

        private void FillProductList()
        {
            TextReader reader;
            using (reader = new StreamReader(@"Products.json"))
            {
                var deserializedProducts = JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
                _productList = deserializedProducts;
                reader.Close();
            }
        }

        public static void WriteOnFile(List<Product> products)
        {
            TextWriter writer;
            using (writer = new StreamWriter(@"Products.json", append: false))
            {
                var serializedProduct = JsonConvert.SerializeObject(products);
                writer.WriteLine(serializedProduct);
                writer.Close();
            }
        }

    }
}
