using Caja_Registradora.DAO;
using Caja_Registradora.Models;
using System.Collections.Generic;

namespace Caja_Registradora.DTO
{
    public class ClosedSalesBoxDTO
    {
        List<ClosedSaleBox> _closedSales;
        List<Sale> _sales;
        ClosedSalesBoxDAO _objDAO;
        public ClosedSalesBoxDTO()
        {
            _closedSales = new();
            _sales = new();
            _objDAO = new();
        }

        public void GenerateClosedSales(List<Sale> sales)
        {
            _objDAO.GenerateCloseSale(sales);
        }

        public List<ClosedSaleBox> GetClosedSalesBox()
        {
            return _objDAO.GetClosedSalesBox();
        }

    }
}
