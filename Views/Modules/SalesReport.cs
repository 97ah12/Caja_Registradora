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
        //Evento Click cargarReporteDeVentas
        private void SalesReport_Load(object sender, System.EventArgs e)
        {
            //Cargamos los datos de ventas guardados
            LoadGrid();
            //Se acopla y llena todo el campo que queda
            Dock = DockStyle.Fill;
            txtFecha.Enabled = false;
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
        //Creamos metodo LoadGrid
        private void LoadGrid()
        {
            //Selecciona el origen de los datos a dgvSales 
            dgvSales.DataSource = _objDTO.GetSales();
        }

        private void GetSalesByDate(DateTime date)
        {
            dgvSales.DataSource = _objDTO.GetSalesByDate(date);
        }
    }
}
