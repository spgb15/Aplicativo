using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class LoginDatos
    {
        private CD_Connection conn = new CD_Connection();

        private string calcularHash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convierte la contraseña en texto claro en un array de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convierte el array de bytes en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        public Usuario? verificarAcceso(string username, string password)
        {

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter;
            cmd.Connection = conn.establecerConexion();
            cmd.CommandText = "SELECT * FROM usuarios WHERE cedula = @username AND pass = @password AND estado = 'A';";
            string hashCalculado = calcularHash(password);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", hashCalculado);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.cerrarConexion();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Usuario usuario = new Usuario
                {
                    cedula = row["cedula"].ToString(),
                    nombre = row["nombre"].ToString(),
                    rol = Convert.ToInt32(row["rol"])
                };
                return usuario;
            }
            else
            {
                return null;
            }

            
        }
    }
}
