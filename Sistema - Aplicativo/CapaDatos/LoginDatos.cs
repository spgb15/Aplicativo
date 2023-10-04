using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            Usuario usuario = null;
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter;
            cmd.Connection = conn.establecerConexion();
            cmd.CommandText = "SELECT * FROM usuarios WHERE cedula = @username AND pass = @password AND estado = 'A';";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.cerrarConexion();

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
