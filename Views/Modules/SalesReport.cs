using Caja_Registradora.DTO;
using Caja_Registradora.Helpers;
using Caja_Registradora.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caja_Registradora.Views.Modules
{
    public partial class SalesReport : UserControl
    {
        SaleDTO _objDTO;
        ClosedSalesBoxDTO _closedSales;
        List<Sale> _salesList;
        public SalesReport()
        {
            InitializeComponent();
            _objDTO = new();
            _closedSales = new();
            _salesList = new();
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
            if (_salesList.Count == 0)
            {
                btnCloseSales.Enabled = false;
            }
        }
        //Creamos metodo LoadGrid
        private void LoadGrid()
        {
            //Selecciona el origen de los datos a dgvSales
            dgvSales.DataSource = _objDTO.GetSales();
            _salesList = _objDTO.GetSales();
        }

        private void btnCloseSales_Click(object sender, EventArgs e)
        {
            try
            {
                _salesList = _objDTO.GetSales();
                _closedSales.GenerateClosedSales(_salesList);
                MessageHelper.ShowMessage("Cierre de Caja Completado");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }
    }
}
