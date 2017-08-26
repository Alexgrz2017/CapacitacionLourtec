using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    public struct Rutas
    {
        public string Chofer;
        public string Compania;
        public   List<Localizacion> Estaciones;
        public Guid Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }


    }
}
