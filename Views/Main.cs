using Caja_Registradora.Views.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Registradora.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            Products productsView = new();
            OpenModule(productsView);
        }

        private void OpenModule(UserControl control)
        {
            if (!mainPanel.Controls.Contains(control))
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(control);
            }
        }
    }
}
