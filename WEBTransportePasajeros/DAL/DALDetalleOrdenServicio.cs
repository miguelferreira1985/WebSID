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
    public class DALDetalleOrdenServicio
    {
        public void InsertarDetalleOrden(DetalleOrdenServicio detalleOrden)
        {
            var comando = new SqlCommand("InsertarDetalleOrdenServicio", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ordenServicio", detalleOrden.IDOrdenServicio);
            comando.Parameters.AddWithValue("@idServicio", detalleOrden.IDServicio);

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
