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

        

        public bool validacion(string input)
        {
            if (input.Length != 10)
            {
                return false;
            }

            int digito, acumulador = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                digito = input[i] - 48;

                if (i % 2 == 0)
                {
                    digito = digito * 2;
                    if (digito > 9)
                    {
                        digito = digito - 9;
                    }
                }

                acumulador = acumulador + digito;
            }

            int resultado;
            resultado = acumulador % 10;

            if (resultado != 0)
            {
                resultado = 10 - resultado;
            }

            digito = input[9] - 48;


            if (resultado == digito)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}