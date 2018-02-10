using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;

namespace TallerTransportePasajeros
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ServicioRepositorio servicioRepositorio = new ServicioRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarServicios();
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            servicioRepositorio.InsertaServicio(txtServicio.Text.ToUpper().Trim(), txtDescripcion.Text.ToUpper().Trim());
            MostrarServicios();
            LimpiarBotones();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarBotones();
        }

        private void LimpiarBotones()
        {
            txtServicio.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
        }

        private void MostrarServicios()
        {
            gvServicios.DataSource = servicioRepositorio.ListaServicios();
            gvServicios.DataBind();
        }
    }
}