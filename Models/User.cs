namespace Caja_Registradora.Models
{
    public partial class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
