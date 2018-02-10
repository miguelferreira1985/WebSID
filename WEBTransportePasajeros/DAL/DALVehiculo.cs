using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace DAL
{
    public class DALVehiculo
    {
        public DataTable ListarVehiculos()
        {
            DataTable dt = new DataTable();

            using (var comando = new SqlCommand("SP_ListarVehiculos", Conexion.AbrirConexion()))
            {
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
            }

            return dt;
        }

        public void InsertarVehiculo(Vehiculo vehiculo)
        {
            using (var comando = new SqlCommand("SP_InsertarVehiculo",Conexion.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@marca", vehiculo.Marca);
                comando.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                comando.Parameters.AddWithValue("@anio", vehiculo.Anio);
                comando.Parameters.AddWithValue("@placas", vehiculo.Placas);
                comando.Parameters.AddWithValue("@fechaAlta", vehiculo.FechaAlta);

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

        public void DesactivarVehiculo(Vehiculo vehiculo)
        {
            using (var comando = new SqlCommand("DesactivarVehiculo", Conexion.AbrirConexion()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idVehiculo", vehiculo.IDVehiculo);
                comando.Parameters.AddWithValue("@fechaBaja", vehiculo.FechaBaja);

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
}
