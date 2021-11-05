using Caja_Registradora.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Caja_Registradora.DAO
{
    public class ProductDAO
    {
        //Declaracion del modelo _product
        Product _product;
        //Declaracion de la lista _productList
        List<Product> _productList;
        //Creación constructor
        public ProductDAO()
        {
            //Instancio la declaracion de _product
            _product = new();
            //Instancio la lista _productList
            _productList = new();
        }
        //Llamo método CreateProduct de tipo Product y como parametro product
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

        //Creamos método FillProductList para leer nuestros archivos de Texto en Products.Json
        private void FillProductList()
        {
            //Llamamos la clase TextReader que nos permite escribir archivos de Texto
            TextReader reader;
            //Instanciamos la clase StreamReader para que lea dentro de Productos.Json nuestra lista de productos
            using (reader = new StreamReader(@"Products.json"))
            {
                //Aqui deserializamos la lista para poder ver el archivo
                var deserializedProducts = JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
                //Igualamos _producList con la lista ya deserialzada para poder leer el archivo.
                _productList = deserializedProducts;
                //Aqui se cierra la lectura del archivo
                reader.Close();
            }
        }
        //Creamos método WriteOnFile para escribir los productos y añadirlos a la lista
        public static void WriteOnFile(List<Product> products)
        {
            //Llamamos TextWriter que nos permite escrbir en nuestra carpeta Products.Json
            TextWriter writer;
            //Instanciamos StreamWriter que nos permite ya como tal escrbir el archivo texto
            using (writer = new StreamWriter(@"Products.json", append: false))
            {
                //Aqui se serializa la lista para poder escribir el archivo
                var serializedProduct = JsonConvert.SerializeObject(products);
                //Aqui la lista se pasa a texto (string)
                writer.WriteLine(serializedProduct);
                //Se cierra la escritura del archivo
                writer.Close();
            }
        }

    }
}
