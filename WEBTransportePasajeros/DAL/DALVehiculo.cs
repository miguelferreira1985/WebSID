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
        public List<Vehiculo> ListarVehiculos()
        {
            List<Vehiculo> vehiculoList = new List<Vehiculo>();

            var comando = new SqlCommand("SP_ListarVehiculos", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(comando);

                DataTable dt = new DataTable();

                da.Fill(dt);

                Conexion.CerrarConexion();

                foreach (DataRow dr in dt.Rows)
                {
                    vehiculoList.Add(
                        new Vehiculo
                        {
                            IDVehiculo = Convert.ToInt32(dr["IDVehiculo"]),
                            Marca = Convert.ToString(dr["Marca"]),
                            Modelo = Convert.ToString(dr["Modelo"]),
                            Anio = Convert.ToString(dr["Anio"]),
                            Placas = Convert.ToString(dr["Placas"]),
                            FechaAlta = Convert.ToDateTime(dr["FechaAlta"]),
                            FechaBaja = Convert.ToDateTime(dr["FechaBaja"]),
                            Estado = Convert.ToString(dr["Estado"])
                        }

                        );

                }
            }
            catch (Exception)
            {

                throw;
            }
            return vehiculoList;
        }
    }
}
