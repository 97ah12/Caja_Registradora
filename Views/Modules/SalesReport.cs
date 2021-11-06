using Caja_Registradora.DTO;
using System;
using System.Windows.Forms;

namespace Caja_Registradora.Views.Modules
{
    public partial class SalesReport : UserControl
    {
        SaleDTO _objDTO;
        public SalesReport()
        {
            InitializeComponent();
            _objDTO = new();
        }

        private void SalesReport_Load(object sender, System.EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvSales.DataSource = _objDTO.GetSales();
        }
    }
}
