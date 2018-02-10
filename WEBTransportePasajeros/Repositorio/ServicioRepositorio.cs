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
    public class ServicioRepositorio
    {
        DALServicio datoServicio = new DALServicio();

        public DataTable ListaServicios()
        {
            DataTable dt = new DataTable();

            dt = datoServicio.ListarServicios();

            return dt;
        }

        public void InsertaServicio(string nombre,string descripcion)
        {
            Servicio servicio = new Servicio()
            {
                Nombre = nombre,
                Descripcion = descripcion
            };

            datoServicio.InsertarServicio(servicio);
        }
    }
}
