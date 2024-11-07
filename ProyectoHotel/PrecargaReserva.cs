using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoHotel.GestionDeHabitaciones;

namespace ProyectoHotel
{
    internal class PrecargaReserva
    {
        public List<Reserva> CargarReserva( List <Habitacion> habitaciones, List<Usuario> usuarios)
        {
            List<Reserva> reservas = new List<Reserva>();



            reservas.Add(new Reserva(1, 1, new DateTime(2024, 3, 12), new DateTime(2024, 3, 14), new DateTime(2024, 3, 11), usuarios[1], habitaciones[1]));

            reservas.Add(new Reserva(2, 3, new DateTime(2024,4, 11), new DateTime(2024, 4, 14), new DateTime(2024, 3, 11), usuarios[2], habitaciones[2]));
            return reservas;
        }

        
       
    }
}
