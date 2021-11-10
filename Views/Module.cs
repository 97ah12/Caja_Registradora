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
    public partial class Module : Form
    {
        public Module(UserControl control)
        {
            InitializeComponent();
            OpenModule(control);
        }

        private void OpenModule(UserControl control)
        {
            if (!panelContainer.Controls.Contains(control))
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(control);
            }
        }
    }
}
