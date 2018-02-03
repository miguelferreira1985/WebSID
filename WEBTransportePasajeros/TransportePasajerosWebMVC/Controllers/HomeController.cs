using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositorio;

namespace TransportePasajerosWebMVC.Controllers
{
    public class HomeController : Controller
    {
        VehiculoRepositorio vehiculoRepositorio = new VehiculoRepositorio();

        public ActionResult Index()
        {
            ModelState.Clear();

            return View(vehiculoRepositorio.ListaVehiculo());
        }
        // GET: Home

    }
}