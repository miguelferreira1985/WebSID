using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Repositorio
{

    public class PresentacionRepositorio
    {
        DALPresentacion datoPresentacion = new DALPresentacion();

        public DataTable ObtenerPresentacion()
        {
            DataTable dt = new DataTable();

            dt = datoPresentacion.ObtenerPresentacion();

            return dt;
        }
    }
}
