using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Camiones.Datos
{
    internal class CONEXIONMAESTRA
    {
        public static string conexion = ("Data source = 192.168.100.49; Initial Catalog = Camiones; Integrated Security=False");
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void Abrir()
        {
            if (conectar.State == System.Data.ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void Cerrar()
        {
            if (conectar.State == System.Data.ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
