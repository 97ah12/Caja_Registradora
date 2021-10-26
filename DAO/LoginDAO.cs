using Caja_Registradora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Registradora.DAO
{
    public class LoginDAO
    {
        readonly User _user;
        //Este es el contruector de la Clase DAO que instancia los datos por defecro de inicio de sesion.
        public LoginDAO()
        {
            // Esto simula un usuario y contraseña registardo desde la Base de Datos
            _user = new() 
            {
                UserName = "Admin",
                Password = "1234*"
            };
        }

        /* 
         * Este metodo me devuelte el modelo privado llamado _user (Contiene el usuario y contraseña por defecto)
         * el cual voy a comparar en la clase LoginDTO con los datos recibidos por el usuario desde la vista
        */
        public User LoginUser()
        {
            return _user;
        }
    }
}
