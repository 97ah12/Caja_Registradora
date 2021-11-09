using Caja_Registradora.Models;

namespace Caja_Registradora.DAO
{
    public class LoginDAO
    {
        //Declaracion del campo _user es Readonly porque la instancia _user unicamente se va a crear dentro de un constructor
        readonly User _user;
        //Este es el contructor de la Clase DAO que instancia los datos por defecto de inicio de sesion.
        public LoginDAO()
        {
            // Aca se crea la Instancia de _user
            // Esto simula un usuario y contraseña registardo desde la Base de Datos
            _user = new()
            {
                UserName = "A",
                Password = "1"
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
