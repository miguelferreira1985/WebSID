using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;
using System.Threading;
using System.Data;

namespace TallerTransportePasajeros
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();
        OrdenServicioRepositorio ordenServicioRepositorio = new OrdenServicioRepositorio();
        DetalleOrdenServicioRepositorio detalleOrdenRepositorio = new DetalleOrdenServicioRepositorio();
        ServicioRepositorio servicioRepositorio = new ServicioRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDropDown();
        }

        protected void btnGenerarOrden_Click(object sender, EventArgs e)
        {
            ordenServicioRepositorio.InsertaOrdenServicio(Convert.ToInt32(dlVehiculo.SelectedValue), Convert.ToInt32(dlEmpleado.SelectedValue),
                txtKilometraje.Text.ToUpper().Trim(), txtObservaciones.Text.ToUpper().Trim());

            lblNumeroOrden.Text = ordenServicioRepositorio.ObtenerUltimaOrden();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            detalleOrdenRepositorio.InsertaDetalleOrden(Convert.ToInt32(lblNumeroOrden.Text), Convert.ToInt32(dlServicio.SelectedValue));
        }

        private void CargarDropDown()
        {
            dlVehiculo.DataSource = vehiculoRepositorio.ListaVehiculo();
            dlVehiculo.DataTextField = "Placas";
            dlVehiculo.DataValueField = "ID";
            dlVehiculo.DataBind();
            dlVehiculo.SelectedIndex = 0;

            dlEmpleado.DataSource = ordenServicioRepositorio.ObtenerEmpleado();
            dlEmpleado.DataTextField = "Empleado";
            dlEmpleado.DataValueField = "IDEmpleado";
            dlEmpleado.DataBind();
            dlEmpleado.SelectedIndex = 0;

            dlServicio.DataSource = servicioRepositorio.ListaServicios();
            dlServicio.DataTextField = "Nombre";
            dlServicio.DataValueField = "ID";
            dlServicio.DataBind();
            dlServicio.SelectedIndex = 0;


        }

    }
}