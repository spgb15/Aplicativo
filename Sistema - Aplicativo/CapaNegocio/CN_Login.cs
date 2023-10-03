using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Login
    {
        LoginDatos datos = new LoginDatos();

        public Usuario Login(string  username, string password)
        {
            return datos.verificarAcceso(username, password);
        }
    }
}