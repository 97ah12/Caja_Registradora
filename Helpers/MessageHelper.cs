using System.Windows.Forms;

namespace Caja_Registradora.Helpers
{
    //Creamos la clase MessageHelper de modo Publica para poderla llamar desde cualquier otra clase
    public class MessageHelper
    {

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowErrorMessage(string ex)
        {
            MessageBox.Show(ex, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}
