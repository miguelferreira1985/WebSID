using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallePedido
    {
        public int IDDetallePedido { get; set; }
        public int IDProducto { get; set; }
        public decimal Cantidad { get; set; }

        public DetallePedido()
        {

        }

        public DetallePedido(int idDetallePedido, int idProducto, decimal cantidad)
        {
            this.IDDetallePedido = idDetallePedido;
            this.IDProducto = idProducto;
            this.Cantidad = cantidad;
        }
    }
}
