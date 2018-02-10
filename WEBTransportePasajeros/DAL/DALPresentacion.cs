using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALPresentacion
    {
        public DataTable ObtenerPresentacion()
        {
            DataTable dt = new DataTable();

            var comando = new SqlCommand("ObtenerPresentacion", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);

                Conexion.CerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }
    }
}
