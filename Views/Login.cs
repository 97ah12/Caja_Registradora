using Caja_Registradora.DAO;
using Caja_Registradora.DTO;
using Caja_Registradora.Helpers;
using Caja_Registradora.Models;
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
    public partial class Login : Form
    {
        readonly LoginDTO _loginDTO;

        public Login()
        {
            InitializeComponent();
            _loginDTO = new();
        }

        public void Ingresar()
        {
            try
            {
                // Modelo que recibo desde la vista para comparar con el metodo LoginUser en clase DAO atravez de Clase DTO
                User user = new()
                {
                    UserName = txtUsuario.Text,
                    Password = txtContrasena.Text
                };
                bool IsCorrect = _loginDTO.LoginUser(user);
                if (IsCorrect){
                    Main main = new();
                    MessageHelper.ShowMessage("Bienvenido a Caja Registradora");
                    user.IsLoggedIn = true;
                    main.Show();
                    Close();
                }
                else
                    MessageHelper.ShowErrorMessage("Usuario o Contraseña invalidos");

            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
    }
}
 