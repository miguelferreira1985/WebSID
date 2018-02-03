using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace Repositorio
{
    public class VehiculoRepositorio
    {
        public List<Vehiculo> ListaVehiculo()
        {
            DALVehiculo datoVehiculo = new DALVehiculo();

            List<Vehiculo> vehiculoLista = datoVehiculo.ListarVehiculos();

            return vehiculoLista;
        }
    }
}
