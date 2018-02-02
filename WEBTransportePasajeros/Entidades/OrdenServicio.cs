using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class OrdenServicio
    {
        public int IDOrdenServicio { get; set; }
        public int IDVehiculo { get; set; }
        public int IDEmpleado { get; set; }
        public string KilometrajeActual { get; set; }
        public string Observaciones { get; set; }

        public OrdenServicio()
        {

        }

        public OrdenServicio(int idOrdenServicio, int idVehiculo, int idEmpleado, string kilometrajeActual, string observaciones)
        {
            this.IDOrdenServicio = idOrdenServicio;
            this.IDVehiculo = idVehiculo;
            this.IDEmpleado = idEmpleado;
            this.KilometrajeActual = kilometrajeActual;
            this.Observaciones = observaciones;
        }

    }
}
