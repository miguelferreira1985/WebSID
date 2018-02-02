using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleOrdenServicio
    {
        public int IDDetalleOrdenServicio { get; set; }
        public int IDOrdenServicio { get; set; }
        public int IDServicio { get; set; }

        public DetalleOrdenServicio()
        {

        }

        public DetalleOrdenServicio(int idDetalleOrdenServicio, int idOrdenServicio, int idServicio)
        {
            this.IDDetalleOrdenServicio = idDetalleOrdenServicio;
            this.IDOrdenServicio = idOrdenServicio;
            this.IDServicio = idServicio;
        }
    }
}
