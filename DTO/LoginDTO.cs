using Caja_Registradora.DAO;
using Caja_Registradora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Registradora.DTO
{
    public class LoginDTO
    {
        //Declaracion de clase DAO y el modelo user
        readonly LoginDAO _objDAO;
        User _user;
        
        
        //Constructor
        public LoginDTO()
        {
            //Instanciando las clases declaradas
            _objDAO = new();
            _user = new();
        }

        //Metodo de comparacion de usuario y contraseña
        public bool LoginUser(User user)
        {
            //Llamado del metodo user de la clase DAO, que retorna user(Modelo)
            _user = _objDAO.LoginUser();
            /*Se valida si usuario y contraseña que viene de DAO coincide 
            con el parametro del usuario enviado desde la vista y retorna TRUE si la comparacion es Correcta,
            FALSE si algun dato no coincide
            */
            if (user.UserName == _user.UserName && user.Password == _user.Password)
                return true;
            else
                return false;
        }
    }
}
