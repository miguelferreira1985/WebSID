using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexion
    {
        const string sCadenaConexion = @"Data Source=FERREIRAPC\SQL;Initial catalog=BDTransportePasajeros;Integrated security=true;";
        private static readonly SqlConnection conexion = new SqlConnection(sCadenaConexion);

        public static SqlConnection AbrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (SqlException exSql)
            {

                throw exSql;
            }

            return conexion;
        }

        public static SqlConnection CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (SqlException exSql)
            {

                throw exSql;
            }

            return conexion;
        }
    }
}
