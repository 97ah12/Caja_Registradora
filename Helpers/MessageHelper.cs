using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Registradora.Helpers
{
    public class MessageHelper
    {
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowErrorMessage(string ex)
        {
            MessageBox.Show(ex,"Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}
