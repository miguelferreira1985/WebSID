using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entidades;

namespace Repositorio
{
    public class DetalleOrdenServicioRepositorio
    {
        public void InsertaDetalleOrden(int idOrdenServicio, int idServicio)
        {
            DetalleOrdenServicio detalleOrden = new DetalleOrdenServicio()
            {
                IDOrdenServicio = idOrdenServicio,
                IDServicio = idServicio
            };

            DALDetalleOrdenServicio datoDetalleOrden = new DALDetalleOrdenServicio();

            datoDetalleOrden.InsertarDetalleOrden(detalleOrden);
        }
    }
}
