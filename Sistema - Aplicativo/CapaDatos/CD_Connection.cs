using MySql.Data.MySqlClient;



namespace CapaDatos
{
    public class CD_Connection
    {
        private static string server = "localhost";
        private static string bd = "Hablemos";
        private static string user = "root";
        private static string pass = "";
        private static string port = "3306";


        MySqlConnection conn = new MySqlConnection();

        private string cadena = "server="+server+";"+"port="+port+";"+"user id="+user+";"+"password="+pass+";"+"database="+bd+";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conn.ConnectionString = cadena;
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return conn;
        }

        public MySqlConnection cerrarConexion()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }

            return conn;
        }

    }
}