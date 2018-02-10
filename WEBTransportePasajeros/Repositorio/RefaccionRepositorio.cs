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
    public class RefaccionRepositorio
    {
        DALRefaccion datoRefaccion = new DALRefaccion();

        public DataTable ListaRefacciones()
        {
            DataTable dt = new DataTable();

            dt = datoRefaccion.ListarRefacciones();

            return dt;
        }

        public void InsertaRefaccion(int idCategoriaRefaccion, int idPresentacion, string marca, string nombre, decimal stock)
        {
            Refaccion refaccion = new Refaccion()
            {
                IDCategoriaRefaccion = idCategoriaRefaccion,
                IDPresentacion = idPresentacion,
                Marca = marca,
                Nombre = nombre,
                Stock = stock
            };

            datoRefaccion.InsertarRefaccion(refaccion);
        }
    }
}
