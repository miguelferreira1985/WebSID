using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Vehiculo
    {
        public int IDVehiculo { get; set; }
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Display( Name ="Modelo")]
        public string  Modelo { get; set; }
        [Display( Name = "Año")]
        public string Anio { get; set; }
        [Display(Name = "Placas")]
        public string  Placas { get; set; }
        [Display( Name = "Fecha de Alta")]
        public DateTime FechaAlta { get; set; }
        [Display( Name = "Fecha de Baja")]
        public DateTime FechaBaja { get; set; }
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        public Vehiculo()
        {

        }

        public Vehiculo(int idVehiculo, string marca, string modelo, string anio, string placas, DateTime fechaAlta, DateTime fechaBaja, string estado)
        {
            this.IDVehiculo = idVehiculo;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
            this.Placas = placas;
            this.FechaAlta = fechaAlta;
            this.FechaBaja = fechaBaja;
            this.Estado = estado;
        }
    }
}
