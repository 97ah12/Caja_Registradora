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
            if (_productList == null)
            {
                _productList = new();
                _productList.Add(product);
                WriteOnFile(_productList);
            }
            else
            {
                _productList.Add(product);
                WriteOnFile(_productList);
            }
        }

        public List<Product> GetProductList()
        {
            // retorna la lista de productos Global
            FillProductList();
            return _productList;
        }

        public Product GetProductByCode(string code)
        {
            //encontramos el codigo del producto y lo comparamos con nuestra expresion landa
            Product product = _productList.Find(p => p.Code == code);
            return product;
        }
        //Creamos metodo para actualizar un producto
        public Product UpdateSelectedProduct(Product product)
        {
            //Buscamos y comparamos el index del producto con nuestra expresion landa y el codigo del producto
            int productIndex = _productList.IndexOf(_productList.Find(p => p.Code == product.Code));
            //Con el index hallado igualamos para que nos traiga todo el producto como tal
            Product updatedProduct = _productList[productIndex] = product;
            //Lo actualiazamos en _productList
            _productList[productIndex] = updatedProduct;
            //Escribimos nuestro archivo actualizado en nuestra carpeta Json
            WriteOnFile(_productList);
            return updatedProduct;
        }
        //Creamos metodo para actualizar la venta de un producto
        public void UpdateSaledProduct(string productCode, int quantity)
        {
            GetProductList();
            //Obtenemos el index del producto comparando nuestra expresion landa con el codigo del producto
            int productIndex = _productList.IndexOf(_productList.Find(p => p.Code == productCode));
            //Asignamos a updateProduct el producto encontrado anteriormente
            Product updatedProduct = _productList[productIndex];
            //Asignacion Compuesta con (-=)
            updatedProduct.Quantity -= quantity;
            //Actualizamos la lista
            _productList[productIndex] = updatedProduct;
            //Escribimos la lista actualizada en nuestro archivo Json
            WriteOnFile(_productList);
        }
        //Creamos metodo DeleteProduct
        public void DeleteProduct(string productCode)
        {
            //Obtenemos el index del producto comparando nuestra expresion landa con el codigo del producto
            //Guardamos el index del producto en productIndex
            int productIndex = _productList.IndexOf(_productList.Find(p => p.Code == productCode));
            //Usamos metodo RemoveAt() y le pasamos como parametro productIndex
            _productList.RemoveAt(productIndex);
            //Escribe la lista  actualizada en nuestro archivo Json
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
