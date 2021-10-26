using Caja_Registradora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public List<Product> GetProductList()
        {
            // retorna la lista de productos Global
            return _productList;
        }
    }
}
