using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Refaccion
    {
        public int IDRefaccion { get; set; }
        public int IDCategoriaRefaccion { get; set; }
        public int IDPresentacion { get; set; }
        public string Marca { get; set; }
        public string  Nombre { get; set; }
        public decimal Stock { get; set; }

        public Refaccion()
        {

        }

        public Refaccion(int idRefaccion, int idCategoriaRefaccion, int idPresentacion, string marca, string nombre, decimal stock)
        {
            this.IDRefaccion = idRefaccion;
            this.IDCategoriaRefaccion = idCategoriaRefaccion;
            this.IDPresentacion = idPresentacion;
            this.Marca = marca;
            this.Nombre = nombre;
            this.Stock = stock;
        }
    }
}
