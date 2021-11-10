﻿using Caja_Registradora.DTO;
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
            //Cargamos el grid
            LoadGrid();
            //Se acopla y llena todo el campo que queda
            Dock = DockStyle.Fill;
            datePicker.Value = DateTime.Now;
        }

        private void LoadGrid()
        {
            dgvSales.DataSource = _objDTO.GetSales();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = datePicker.Value;
            GetSalesByDate(date);
        }

        private void GetSalesByDate(DateTime date)
        {
            dgvSales.DataSource = _objDTO.GetSalesByDate(date);
        }
    }
}
