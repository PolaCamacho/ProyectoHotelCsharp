using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class GestionDeHabitaciones
    {

        
       public class Precargar {


            public List<Habitacion> CargarHabitaciones()
            {
                List<Habitacion> habitaciones = new List<Habitacion>();
                
                for (int i = 1; i <= 15; i++)
                {
                    string tipo = i <= 5 ? "Simple" : i <= 10 ? "Doble" : "Suite";
                    int precio = tipo == "Simple" ? 100 : tipo == "Doble" ? 150 : 200;
                    int cantidadHuesped = tipo == "Simple" ? 1 : tipo == "Doble" ? 2 : 4;

                    habitaciones.Add(new Habitacion(i, tipo, cantidadHuesped, precio));
                }

               

                return habitaciones;
            }


        }



    }
    }

