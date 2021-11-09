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
        Product product;
        public SaleDTO()
        {
            _objDAO = new();
            _productDAO = new();
            product = new();
        }

        public Sale SaleProduct(Sale sale)
        {
            Sale saleResponse = new();
            _productList = _productDAO.GetProductList();
            if (_productList.Any(p => p.Code == sale.ProductCode))
            {
                product = _productList.Find(p => p.Code == sale.ProductCode);
                if (product.Quantity >= sale.Quantity)
                {
                    saleResponse = sale;
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
