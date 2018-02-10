using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;

namespace TallerTransportePasajeros
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CategoriaRefaccionRepositorio categoriaRefaccionRepositorio = new CategoriaRefaccionRepositorio();

        PresentacionRepositorio presentacionRepositorio = new PresentacionRepositorio();

        RefaccionRepositorio refaccionRepositorio = new RefaccionRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDropDown();
            MostrarRefacciones();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            refaccionRepositorio.InsertaRefaccion(Convert.ToInt32(dlCategoria.SelectedValue), Convert.ToInt32(dlPresentacion.SelectedValue),
                txtMarca.Text.ToUpper().Trim(), txtNombre.Text.ToUpper().Trim(), Convert.ToDecimal(txtStock.Text));
            LimpiarBotones();
            CargarDropDown();
            MostrarRefacciones();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarBotones();
            CargarDropDown();
        }

        protected void txtStock_TextChanged(object sender, EventArgs e)
        {
        }
        private void LimpiarBotones()
        {
            txtMarca.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtStock.Text = String.Empty;
        }

        private void CargarDropDown()
        {
            dlCategoria.DataSource = categoriaRefaccionRepositorio.ObtenerCategorias();
            dlCategoria.DataTextField = "Nombre";
            dlCategoria.DataValueField = "IDCategoriaRefaccion";
            dlCategoria.DataBind();
            dlCategoria.SelectedIndex = 0;

            dlPresentacion.DataSource = presentacionRepositorio.ObtenerPresentacion();
            dlPresentacion.DataTextField = "Nombre";
            dlPresentacion.DataValueField = "IDPresentacion";
            dlPresentacion.DataBind();
            dlPresentacion.SelectedIndex = 0;

        }

        private void MostrarRefacciones()
        {
            gvRefacciones.DataSource = refaccionRepositorio.ListaRefacciones();
            gvRefacciones.DataBind();
        }

    }
}