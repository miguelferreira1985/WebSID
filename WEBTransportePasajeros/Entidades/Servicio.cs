using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio
    {
        public int IDServicio { get; set; }
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }

        public Servicio()
        {

        }

        public Servicio(int idServicio, string nombre, string descripcion)
        {
            this.IDServicio = idServicio;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
    }
}
