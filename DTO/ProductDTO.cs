using Caja_Registradora.DAO;
using Caja_Registradora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Registradora.DTO
{
    public class ProductDTO
    {
        //Declarando clase DAO
        ProductDAO _objDAO;
        //Declaracion de productList
        List<Product> _productList;
        //constructor
        public ProductDTO()
        {
            //Instanciando clase DAO
            _objDAO = new();
        }

        public bool CreateProduct(Product product)
        {
            /*La lista de productos es igual a la respuesta del metodo GetProductList desde la Clase DAO*/
            _productList = _objDAO.GetProductList();
            /*Verifica dentro de la lista que no contenga en producto enviado, Si no lo contiene permitira
            guardarlo en la lista de la Clase DAO y retorna TRUE d elo contrario retorna FALSE
            */
            if(_productList.Contains(product))
                return false;
            else
            {
                _objDAO.CreateProduct(product);
                return true;
            }
        }

    }
}
