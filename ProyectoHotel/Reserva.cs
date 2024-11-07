using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class Reserva 
    {
        public int idReserva {  get; set; }
        
        public int numeroHabitacion { get; set; }

       // public Huesped persona { get; set; }
       public Usuario usuario { get; set; }
        public Habitacion habitacionReservada { get; set; }

        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin {  get; set; }
        public DateTime fechaReserva { get; set; }

        public Reserva (int idReserva, int numeroHabitacion, DateTime fechaInicio, DateTime fechaFin, DateTime fechaReserva, Usuario usuario, Habitacion habitacionReservada)
       
        {
           this.idReserva = idReserva;
            this.numeroHabitacion = numeroHabitacion;
            this.fechaInicio = fechaInicio;
           this.fechaFin = fechaFin;
            this.fechaReserva = DateTime.Now;
           this.usuario = usuario;
            
            // this.persona = persona;
            this.habitacionReservada = habitacionReservada;
        }
    }
   
}

