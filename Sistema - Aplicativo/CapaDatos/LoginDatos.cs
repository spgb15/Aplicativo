using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class LoginDatos
    {
        private CD_Connection conn = new CD_Connection();

        public Usuario verificarAcceso(string username, string password)
        {
            Usuario usuario = new Usuario();
            DataTable dt = new DataTable();
            string connectionString = "Server=tu_servidor_mysql;Database=nombre_de_tu_base_de_datos;Uid=nombre_de_usuario;Pwd=contrasenia;";

            using (MySqlConnection connection = conn.establecerConexion())
            {
                connection.Open();
                string query = "SELECT * FROM usuario WHERE username = @username AND pass = @password AND estado = 'A'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                usuario = new Usuario
                {
                    cedula = row["cedula"].ToString(),
                    nombre = row["nombre"].ToString(),
                    rol = Convert.ToInt32(row["rol"])
                };
            }

            return usuario;
        }
    }
}
