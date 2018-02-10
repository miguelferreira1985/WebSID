using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using DAL;

namespace Repositorio
{
    public class OrdenServicioRepositorio
    {
        DALOrdenServicio datoOrdenServicio = new DALOrdenServicio();

        public DataTable ObtenerEmpleado()
        {
            DataTable dt = new DataTable();

            dt = datoOrdenServicio.ObtenerEmpleados();

            return dt;
        }

        public string ObtenerUltimaOrden()
        {
            //DataTable dt = new DataTable();

            //dt = datoOrdenServicio.ObtenerUltimaOrden();
            string registro = "";

            registro = datoOrdenServicio.ObtenerUltimaOrden();

            return registro;
        }

        public void InsertaOrdenServicio(int idVehiculo,int idEmpleado,string kmActual,string observaciones)
        {
            OrdenServicio ordenServicio = new OrdenServicio()
            {
                IDVehiculo = idVehiculo,
                IDEmpleado = idEmpleado,
                KilometrajeActual = kmActual,
                Observaciones = observaciones,
                Fecha = DateTime.Now

            };

            datoOrdenServicio.InsertarOrden(ordenServicio);
        }
    }
}
