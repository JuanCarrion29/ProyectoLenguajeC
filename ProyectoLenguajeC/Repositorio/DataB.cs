using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLenguajeC.Repositorio
{
    public static class DataB
    {
        private static readonly string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }



    }
}
