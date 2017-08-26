using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    public struct Reserva
    {
        private Localizacion destino;
        private Localizacion salida;
        private DateTime FechaSalida;
    
    public Localizacion  Destino
    {
        get; set;
    }

    public Localizacion Salida
    {
        get; set;
    }
    }

}
