using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public int IDPedido { get; set; }
        public DateTime Fecha { get; set; }

        public Pedido()
        {

        }

        public Pedido(int idPedido, DateTime fecha)
        {
            this.IDPedido = idPedido;
            this.Fecha = fecha;
        }
    }
}
