using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Data;

namespace Repositorio
{
    public class VehiculoRepositorio
    {
        DALVehiculo datoVehiculo = new DALVehiculo();

        public void InsertaVehiculo(string marca,string modelo,string anio,string placas)
        {
            Vehiculo vehiculo = new Vehiculo()
            {
                Marca = marca,
                Modelo = modelo,
                Anio = anio,
                Placas = placas,
                FechaAlta = DateTime.Now

            };

            datoVehiculo.InsertarVehiculo(vehiculo);
        }

        public DataTable ListaVehiculo()
        {
            DataTable dt = new DataTable();

            dt = datoVehiculo.ListarVehiculos();

            return dt;
        }

        public void DesactivaVehiculo(int idVechiculo)
        {
            Vehiculo vehiculo = new Vehiculo()
            {
                IDVehiculo = idVechiculo,
                FechaBaja = DateTime.Now
            };

            datoVehiculo.DesactivarVehiculo(vehiculo);
        }
    }
}
