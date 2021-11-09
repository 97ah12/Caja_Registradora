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

        public Product GetProductByCode(string code)
        {
            Product product = _productList.Find(p => p.Code == code);
            return product;
        }

        public Product UpdateSelectedProduct(Product product)
        {
            int productIndex = _productList.IndexOf(_productList.Find(p => p.Code == product.Code));
            Product updatedProduct = _productList[productIndex] = product;
            _productList[productIndex] = updatedProduct;
            WriteOnFile(_productList);
            return updatedProduct;
        }

        public void UpdateSaledProduct(string productCode, int quantity)
        {
            GetProductList();
            int productIndex = _productList.IndexOf(_productList.Find(p => p.Code == productCode));
            Product updatedProduct = _productList[productIndex];
            //Asignacion Compuesta con (-=)
            updatedProduct.Quantity -= quantity;
            _productList[productIndex] = updatedProduct;
            WriteOnFile(_productList);
        }

        public void DeleteProduct(string productCode)
        {
            int productIndex = _productList.IndexOf(_productList.Find(p => p.Code == productCode));
            _productList.RemoveAt(productIndex);
            WriteOnFile(_productList);
        }

        //Creamos método FillProductList para leer nuestros archivos de Texto en Products.Json
        private void FillProductList()
        {
            //Llamamos la clase TextReader que nos permite leer archivos de Texto
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
                //Aqui se serializa la lista para poder escribir el archivo(la lista se pasa a texto (string))
                var serializedProduct = JsonConvert.SerializeObject(products);
                //m Escribe la lista ya serializada en textoplano
                writer.WriteLine(serializedProduct);
                //Se cierra la escritura del archivo
                writer.Close();
            }
        }

    }
}
