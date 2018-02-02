using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleServicio
    {
        public int IDDetalleServicio { get; set; }
        public int IDServicio { get; set; }
        public int IDRefaccion { get; set; }
        public decimal Cantidad { get; set; }

        public DetalleServicio()
        {

        }

        public DetalleServicio(int idDetalleServicio, int idServicio, int idRefaccion, decimal cantidad)
        {
            this.IDDetalleServicio = idDetalleServicio;
            this.IDServicio = idServicio;
            this.IDRefaccion = idRefaccion;
            this.Cantidad = cantidad;
        }
    }
}
