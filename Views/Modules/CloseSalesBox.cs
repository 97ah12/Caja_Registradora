using Caja_Registradora.DTO;
using System;
using System.Windows.Forms;

namespace Caja_Registradora.Views.Modules
{
    public partial class CloseSalesBox : UserControl
    {
        ClosedSalesBoxDTO _objDTO;
        public CloseSalesBox()
        {
            InitializeComponent();
            _objDTO = new();
        }

        private void CloseSalesBox_Load(object sender, EventArgs e)
        {
            LoadGrid();
            Dock = DockStyle.Fill;
            txtFecha.Enabled = false;
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void LoadGrid()
        {
            dgvClosedSales.DataSource = _objDTO.GetClosedSalesBox();
        }
    }
}
