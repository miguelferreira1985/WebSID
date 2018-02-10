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
    public class DALRefaccion
    {
        public DataTable ListarRefacciones()
        {
            DataTable dt = new DataTable();

            var comando = new SqlCommand("ListarRefacciones", Conexion.AbrirConexion());
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

        public void InsertarRefaccion(Refaccion refaccion)
        {
            var comando = new SqlCommand("InsertarRefaccion", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCategoriaRefaccion", refaccion.IDCategoriaRefaccion);
            comando.Parameters.AddWithValue("@idPresentacion", refaccion.IDPresentacion);
            comando.Parameters.AddWithValue("@marca", refaccion.Marca);
            comando.Parameters.AddWithValue("@nombre", refaccion.Nombre);
            comando.Parameters.AddWithValue("@stock", refaccion.Stock);

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
