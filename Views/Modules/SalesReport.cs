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
            //Cargamos los datos de ventas guardados
            LoadGrid();
            Dock = DockStyle.Fill;
            txtFecha.Enabled = false;
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void LoadGrid()
        {
            dgvSales.DataSource = _objDTO.GetSales();
        }

        private void GetSalesByDate(DateTime date)
        {
            dgvSales.DataSource = _objDTO.GetSalesByDate(date);
        }
    }
}
