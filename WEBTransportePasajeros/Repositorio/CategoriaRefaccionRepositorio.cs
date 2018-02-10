using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Repositorio
{
    public class CategoriaRefaccionRepositorio
    {
        DALCategoriaRefaccion categoriaRefaccion = new DALCategoriaRefaccion();

        public DataTable ObtenerCategorias()
        {
            DataTable dt = new DataTable();

            dt = categoriaRefaccion.ObtenerCategoriaRefaccion();

            return dt;
        }
    }
}
