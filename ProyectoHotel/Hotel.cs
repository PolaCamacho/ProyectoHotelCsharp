using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class Hotel
    {
        public int hotelId { get; set; }
        public string hotelName { get; set; }

        public string ubicHotel {  get; set; }


        public int categoria {  get; set; }

        public string servicio {  get; set; }

        public List <Habitacion> habitaciones { get; set; }

        public List <Huesped> personas { get; set; }
        public List <Reserva> reservas { get; set; }

        public Hotel( int hotelId, string hotelName, string ubicHotel, int categoria, string servicio) {


           this.hotelId = hotelId;
           this.hotelName = hotelName;
           this.ubicHotel = ubicHotel;
           this.categoria = categoria;
           this.servicio = servicio;
           habitaciones = new List <Habitacion>();
            personas = new List<Huesped>();
            reservas = new List<Reserva> ();

        }

        public void AgregarHabitacion(Habitacion habitacion)
        {
            habitaciones.Add(habitacion);
        }

        public void ListarHabitaciones()
        {
            foreach (var habitacion in habitaciones)
            {
                Console.WriteLine(habitacion);
            }
        }
        public void ListarReservas(int id)
        {
            
            Reserva reserva = null;
            foreach (Reserva res in reservas)
            {
                if (res.idReserva == id)
                {
                    reserva = res;
                }
            }
            Console.WriteLine("reserva generada con exito, numero: " + id);
            
        }

        public override string ToString()
        {
            return hotelName + ubicHotel + +categoria + servicio;
        }

        public void AgregarHuesped(Huesped huesped)  
        {
            personas.Add(huesped);
        }

        public void ListarHuesped()
        {
            foreach (var huesped in personas)
            {
                Console.WriteLine(huesped);
            }
        }
        public void AgregarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public List<Habitacion> ListarHabitacionesDisponibles()
        {
            List <Habitacion> habitacionesDisponibles = new List <Habitacion>();
            foreach (var habitacion in habitaciones)
            {
               if(habitacion.disponible)
                {
                    habitacionesDisponibles.Add(habitacion);
                }


            }

            return habitacionesDisponibles;

        }


    }

}





       


       


   
