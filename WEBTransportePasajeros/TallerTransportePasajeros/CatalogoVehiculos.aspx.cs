using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;
using System.Data;

namespace TallerTransportePasajeros
{
    public partial class About : Page
    {
        VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            ListarVehiculos();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            vehiculoRepositorio.InsertaVehiculo(txtMarca.Text.ToUpper().Trim(), txtModelo.Text.ToUpper().Trim(), txtAnio.Text.ToUpper().Trim(), txtPlacas.Text.ToUpper().Trim());
            ListarVehiculos();
            LimpiarBotones();
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarBotones();
        }

        private void LimpiarBotones()
        {
            txtMarca.Text = String.Empty;
            txtModelo.Text = String.Empty;
            txtAnio.Text = String.Empty;
            txtPlacas.Text = String.Empty;
        }

        private void ListarVehiculos()
        {
            gvVehiculo.DataSource = vehiculoRepositorio.ListaVehiculo();
            gvVehiculo.DataBind();
        }

        protected void gvVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void gvVehiculo_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DataTable dt = new DataTable();

            int idVehiculo = 0;

            GridViewRow row = gvVehiculo.Rows[e.RowIndex];
            idVehiculo = Convert.ToInt32(dt.Rows[row.DataItemIndex]["ID"] = ((TextBox)(row.Cells[1].Controls[0])).Text);
            //int idVehiculo = Convert.ToInt32(gvVehiculo.DataKeys[e.RowIndex].Value.ToString());
            //GridViewRow row = (GridViewRow)gvVehiculo.Rows[e.RowIndex];
            //Label lblID = (Label)row.FindControl("lblID");

            //TextBox txtEstado = (TextBox)row.Cells[4].Controls[0];

            //gvVehiculo.EditIndex = -1;

            gvVehiculo.EditIndex = -1;

            vehiculoRepositorio.DesactivaVehiculo(idVehiculo);
        }

        protected void gvVehiculo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id;

            if (e.CommandName == "Desactivar")
            {
                id = Convert.ToInt32(gvVehiculo.SelectedRow.Cells[1].Text);

                vehiculoRepositorio.DesactivaVehiculo(id);

                //ListarVehiculos();
            }
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idVehiculo = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");

            TextBox txtEstado = (TextBox)row.Cells[4].Controls[0];

            GridView1.EditIndex = -1;

            vehiculoRepositorio.DesactivaVehiculo(idVehiculo);
        }

        protected void gvVehiculo_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            //int idVehiculo = Convert.ToInt32(gvVehiculo.DataKeys[e.RowIndex].Value.ToString());
            //GridViewRow row = (GridViewRow)gvVehiculo.Rows[e.RowIndex];
            //Label lblID = (Label)row.FindControl("lblID");

            //TextBox txtEstado = (TextBox)row.Cells[4].Controls[0];

            //gvVehiculo.EditIndex = -1;

            //vehiculoRepositorio.DesactivaVehiculo(idVehiculo);
        }

        protected void gvVehiculo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}