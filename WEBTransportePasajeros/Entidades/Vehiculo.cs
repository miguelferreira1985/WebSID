using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        public int IDVehiculo { get; set; }
        public string Marca { get; set; }
        public string  Modelo { get; set; }
        public string Anio { get; set; }
        public string  Placas { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
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
