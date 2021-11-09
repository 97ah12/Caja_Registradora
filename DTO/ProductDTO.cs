﻿using Caja_Registradora.DAO;
using Caja_Registradora.Models;
using System.Collections.Generic;

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
            //Instanciando clase DAO y _prodcutList
            _objDAO = new();
            _productList = new();
        }

        public bool CreateProduct(Product product)
        {
            /*La lista de productos es igual a la respuesta del metodo GetProductList desde la Clase DAO*/
            _productList = _objDAO.GetProductList();
            /*Verifica dentro de la lista que no contenga en producto enviado, Si no lo contiene permitira
            guardarlo en la lista de la Clase DAO y retorna TRUE d elo contrario retorna FALSE
            */
            if (_productList.Contains(product))
                return false;
            else
            {
                _objDAO.CreateProduct(product);
                return true;
            }
        }
        //Traemos GetProductList de DAO que es donde almacenamos nuestros productos
        public List<Product> GetProductList()
        {
            _productList = _objDAO.GetProductList();
            return _productList;
        }
        //Traemos GetProductByCode de DAO que es donde almacenamos los codigos de los productos
        public Product GetProductByCode(string code)
        {
            Product product = _objDAO.GetProductByCode(code);
            return product;
        }
        //Traemos UpdateSelectedProduct de DAO que es donde almacenamos los productos actualizados
        public Product UpdateSelectedProduct(Product product)
        {
            return _objDAO.UpdateSelectedProduct(product);
        }
        //Traemos DeleteProduct con parametro productCode de DAO 
        public bool DeleteProduct(string productCode)
        {
            //Le pasamos como parametro productCode a DeleteProduct
            _objDAO.DeleteProduct(productCode);
            //Llamamos GetProductList
            GetProductList();
            //Si el productCode esta contenido y el igual al codigo del producto procede a borrarlo
            if (_productList.Contains(_productList.Find(p => p.Code == productCode)))
                return false;
            else
                return true;
        }
    }
}
