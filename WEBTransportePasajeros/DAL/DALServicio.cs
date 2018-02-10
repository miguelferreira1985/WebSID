using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALServicio
    {
        public DataTable ListarServicios()
        {
            DataTable dt = new DataTable();

            var comando = new SqlCommand("ListarServicios", Conexion.AbrirConexion());
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

        public void InsertarServicio(Servicio servicio)
        {
            var comando = new SqlCommand("InsertarServicio", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", servicio.Nombre);
            comando.Parameters.AddWithValue("@descripcion", servicio.Descripcion);


            try
            {
                comando.ExecuteNonQuery();

                Conexion.CerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
