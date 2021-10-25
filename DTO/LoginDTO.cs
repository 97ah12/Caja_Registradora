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
        readonly LoginDAO _objDAO;
        User _user;
        public LoginDTO()
        {
            _objDAO = new();
            _user = new();
        }

        public bool LoginUser(User user)
        {
            _user = _objDAO.LoginUser();
            if (user.UserName == _user.UserName && user.Password == _user.Password)
                return true;
            else
                return false;
        }
    }
}
