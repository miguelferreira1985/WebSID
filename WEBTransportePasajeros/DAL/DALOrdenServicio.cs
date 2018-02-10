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
    public class DALOrdenServicio
    {
        public DataTable ObtenerEmpleados()
        {
            DataTable dt = new DataTable();

            var comando = new SqlCommand("ObtenerEmpleado", Conexion.AbrirConexion());
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

        public void InsertarOrden(OrdenServicio ordenServicio)
        {
            var comando = new SqlCommand("InsertarOrdenServicio", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idVehiculo", ordenServicio.IDVehiculo);
            comando.Parameters.AddWithValue("@idEmpleado", ordenServicio.IDEmpleado);
            comando.Parameters.AddWithValue("@kmActual", ordenServicio.KilometrajeActual);
            comando.Parameters.AddWithValue("@observaciones", ordenServicio.Observaciones);
            comando.Parameters.AddWithValue("@fecha", ordenServicio.Fecha);

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

        public string ObtenerUltimaOrden()
        {
            DataTable dt = new DataTable();

            string registro = "";

            SqlCommand comando = new SqlCommand("ObtenerUltimaOrden", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                registro = comando.ExecuteScalar().ToString();

                Conexion.CerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }

            return registro;
        }
    }
}
