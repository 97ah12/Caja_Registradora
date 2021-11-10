using Caja_Registradora.DAO;
using Caja_Registradora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Registradora.DTO
{
    public class SaleDTO
    {
        readonly SaleDAO _objDAO;
        readonly ProductDAO _productDAO;
        private List<Product> _productList;
        private List<Sale> _sales;
        Product product;
        public SaleDTO()
        {
            _objDAO = new();
            _productDAO = new();
            _sales = new();
            product = new();
        }
        //Creamos metodo SaleProduct de tipo Sale y como parametro sale
        public Sale SaleProduct(Sale sale)
        {
            //Instanciamos saleResponse
            Sale saleResponse = new();
            //Llamamos a GetProducList de DAO y lo guardamos en _productList
            _sales = _objDAO.GetSales();
            _productList = _productDAO.GetProductList();
            //Llamamos el metodo Any que determina cualquier elemento que satisfaga una condicion
            //Si el codigo del modelo product es igual al productCode del modelo sales hace lo sgt:
            if (_productList.Any(p => p.Code == sale.ProductCode))
            {
                //Encontramos el product que cumpla nuestra comparacion 
                product = _productList.Find(p => p.Code == sale.ProductCode);
                if (product.Quantity >= sale.Quantity)
                {
                    int code = 0;
                    saleResponse = sale;
                    if (_sales.Count == 0)
                    {
                        code += 1;
                    }
                    else if (_sales != null)
                    {
                        code = _sales[_sales.Count - 1].SaleCode + 1;
                    }
                    saleResponse.SaleCode = code;
                    //
                    saleResponse.IsCorrect = true;
                    saleResponse.TotalSale = product.Price * sale.Quantity;
                    _objDAO.SaleProduct(saleResponse);
                    return sale;
                }
                else
                {
                    sale.IsCorrect = false;
                    return sale;
                }
                   
            }
            sale.IsCorrect = true;
            return sale;
        }

        public List<Sale> GetSales()
        {
            return _objDAO.GetSales();
        }

        public List<Sale> GetSalesByDate(DateTime date)
        {
            return _objDAO.GetSalesByDate(date);
        }
    }
}
