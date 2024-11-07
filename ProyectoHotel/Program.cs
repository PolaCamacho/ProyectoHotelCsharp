using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using ProyectoHotel;
using static ProyectoHotel.GestionDeHabitaciones;



namespace HoteldelMar
{
    class Program
    {



        static void Main(string[] args)
        {
            
           
            Hotel hotel1 = new Hotel(1, "Hotel del Mar", "Ciudad: L' Santillán de la Sierra.  Pais: España. Direccion: Praza Adam, 4, 0º B",
                  5, " Parking privado -Piscina al aire libre -Gimnasio. -Restaurante. -Servicio a la habitación 24 horas.Wi-Fi gratuito. ");

            var usuariologueado = PrecargarUsuario();
            PrecargarHabitaciones();
            PrecargarHuespedes();
            PrecargarReserva();

            bool repetir = true;
            



                Console.WriteLine("\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\n");
                Console.WriteLine("¡Bienvenido al hotel Estrella del Mar! \n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n");

            Console.WriteLine("1 - Iniciar sesion");
            Console.WriteLine("2 - Registrate");
            Console.WriteLine("3 - Olvide mi contraseña");
            Console.WriteLine("4 - Salir");


            bool salir = true;
            
            int imput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            
            
            switch (imput)
            {
                case 1:
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Console.WriteLine("Ingresa tu mail");
                    string nombreUsuario = Console.ReadLine()?.Trim();
                    Console.WriteLine("Ingresa contraseña:");
                    string contrasenia = Console.ReadLine()?.Trim();


                       
                    if (nombreUsuario == "Juancho@gmail.com" && contrasenia == "UwU" || nombreUsuario == "Lucas@gmail.com" && contrasenia == "Contra67" 
                      )
                        {
                            Console.Clear();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("\n");
                            Console.WriteLine("Bienvenido! Ya era hora de que te tomes unas vacaciones.");
                            Console.WriteLine("\n");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("1- Habitaciones disponibles");
                            Console.WriteLine("\n");
                            Console.WriteLine("2 - Reservar Habitaciones");
                       

                    }
                    else
                    {
                        Console.WriteLine("Nombre de usuario o contraseña invalido");
                        break;

                    }


                    
                 

                        imput = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (imput)
                    {
                        case 1:
                            ListarHabitacionesPorFecha();


                            break;

                                
                        case 2:
                            IngresarNuevaReserva();

                                Console.WriteLine("-------------------------------- \n");

                            Console.WriteLine("1- Realizar una nueva reserva");
                            Console.WriteLine("2- Comprobante de reserva");
                            Console.WriteLine("3- Deseas eliminar la reserva?");

                            imput = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            switch (imput)
                            {
                                case 1: IngresarNuevaReserva();
                                    break;

                                case 2:
                                    Console.WriteLine("Aca va comprobante de reserva");
                                    break;

                                case 3:
                                    EliminarReserva();
                                    break;



                            }


                            break;
                                Console.Clear();

                            
                               
                    }
                       


                        break;

                case 2:
                    Console.WriteLine("Registrate para poder tomarte las mejores vacaciones");
                    Console.WriteLine("Ingresa tu mail: ");
                    string Mail = Console.ReadLine()?.Trim(); 
                    Console.WriteLine("Ingresa tu nueva contraseña: ");
                    string Contrasenia = Console.ReadLine()?.Trim();

                    if(!string.IsNullOrEmpty(Mail) && !string.IsNullOrEmpty(Contrasenia))
                    {
                        Console.WriteLine("Nueva cuenta agregada");
                    }
                    else
                    {
                        Console.WriteLine("Error al crear cuenta");
                    }
                    break;


                case 4: salir = false;
                    break;


                   


                }


            

            






            

            Usuario PrecargarUsuario()
            {
                GestionDeUsuario gestion = new GestionDeUsuario();
                var usuarios = gestion.CargarUsuarios();
                var usuario = usuarios[2];
                return usuario;
            }


            void EliminarReserva()
            {
                Console.WriteLine("Ingrese el ID de la reserva que desea eliminar:");
                int idReserva = int.Parse(Console.ReadLine());

                // Buscar la reserva por ID en las reservas del hotel
                Reserva reservaAEliminar = hotel1.reservas.FirstOrDefault(r => r.idReserva == idReserva);

                if (reservaAEliminar != null)
                {
                    // Verificar si la fecha de la reserva es posterior a la fecha actual
                    if (reservaAEliminar.fechaInicio > DateTime.Now )
                    {
                        hotel1.reservas.Remove(reservaAEliminar);
                        Console.WriteLine($"Reserva con ID {idReserva} eliminada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("La reserva no puede ser eliminada porque ya ha comenzado o está en curso.");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró ninguna reserva con el ID ingresado.");
                }
            }









            void PrecargarReserva()
            {
                GestionDeUsuario gestionusuario = new GestionDeUsuario();
                List<Usuario> usuarios = gestionusuario.CargarUsuarios();
                PrecargaReserva gestion = new PrecargaReserva();
                var reservas = gestion.CargarReserva(hotel1.habitaciones, usuarios);
                foreach (var reserva in reservas)
                {
                    hotel1.AgregarReserva(reserva);
                }
            }


          




            void PrecargarHuespedes()
            {
                GestionDeHuesped gestion = new GestionDeHuesped();
                var huespedes = gestion.CargarHuesped();

                foreach (var huesped in huespedes)
                {

                    hotel1.AgregarHuesped(huesped);
                }

            }



            void AltaHabitacion()
                    {
                        Console.WriteLine("Dar alta habitacion");
                        Console.Write("ingrese un numero de habitacion");
                        int numero = int.Parse(Console.ReadLine()!);
                        Console.Write("ingrese tipo de habitacion");
                        string tipo = Console.ReadLine()!;
                        Console.WriteLine("ingrese espacio de la habitacion");
                        int cantidad = int.Parse(Console.ReadLine())!;
                        Console.WriteLine("ingrese precio diario");
                        int precio = int.Parse(Console.ReadLine());

                        Habitacion nuevaHabitacion = new Habitacion(numero, tipo, cantidad, precio);
                        hotel1.AgregarHabitacion(nuevaHabitacion);

                        Console.WriteLine("Habitacion agregada con exito");

                    }
                    void AltaHuesped()
                    {
                        Console.WriteLine("Nuevo Huesped");
                        Console.Write("Ingrese ID del huesped:");
                        int id = int.Parse(Console.ReadLine()!);
                        Console.Write("Ingrese nombre del huesped:");
                        string Nombre = Console.ReadLine()!;
                        Console.Write("ingrese Apellido");
                        string Apellido = Console.ReadLine()!;
                        Console.Write("ingrese tipo de documento:");
                        string TipoDoc = Console.ReadLine()!;
                        Console.Write("Ingrese Documento");
                        int Documento = int.Parse(Console.ReadLine()!);
                        Console.Write("ingrese numero de contacto:");
                        int Contacto = int.Parse(Console.ReadLine()!);
                        Console.Write("Ingrese Mail");
                        string Mail = Console.ReadLine()!;
                        Console.Write("ingrese pais de residencia");
                        string pais = Console.ReadLine()!;


                        Huesped crearHuesped = new Huesped(id, Nombre, Apellido, TipoDoc, Documento, Contacto, Mail, pais);
                        hotel1.AgregarHuesped(crearHuesped);
                        Console.WriteLine("Huesped agregado con exito!");
                    }

                    void PrecargarHabitaciones()
                    {
                        Precargar gestion = new Precargar();
                        var habitaciones = gestion.CargarHabitaciones();
                        foreach (var habitacion in habitaciones)
                        {

                            hotel1.AgregarHabitacion(habitacion);
                        }

                        

                    }

            bool ChequearDisponibilidad(Habitacion habitacion, DateTime FechaE, DateTime FechaS)
            {
                List<Reserva> todasLasReservas = hotel1.reservas;
               
                bool estaReservada = false;
                foreach (var r in todasLasReservas)
                {
                    if (r.habitacionReservada.idNumeroHabitacion == habitacion.idNumeroHabitacion &&
                        ((FechaE >= r.fechaInicio && FechaE <= r.fechaFin) ||
                         (FechaS >= r.fechaInicio && FechaS <= r.fechaFin) ||
                         (FechaE <= r.fechaInicio && FechaS >= r.fechaFin)))
                    {
                        estaReservada = true;
                    }
                }

                return estaReservada;
            }


            void IngresarNuevaReserva()
            {
                int id = IdReserva();
                ListarHabitacionesDisponibles();
                Console.WriteLine("\nNueva reserva:");

                // Selección de habitación y fechas
                Console.Write("Elija número de habitación: ");
                int habitacionID = int.Parse(Console.ReadLine()!);
                Console.Write("Elija fecha de entrada (D/M/A): ");
                DateTime FechaE = DateTime.Parse(Console.ReadLine());
                Console.Write("Elija fecha de salida (D/M/A): ");
                DateTime FechaS = DateTime.Parse(Console.ReadLine());
               DateTime fechaHoy = DateTime.Now; 

                // Validación de duración de la reserva
                TimeSpan duracion = FechaS - FechaE;
                if (duracion.Days > 30)
                {
                    Console.WriteLine("La duración de la reserva no puede superar los 30 días consecutivos.");
                    return;
                }
                Console.Clear();

                Habitacion habitacion = BuscarHabitacionPorId(habitacionID);

                bool estaReservada = ChequearDisponibilidad( habitacion, FechaE, FechaS);
                if (estaReservada) {
                    Console.WriteLine("Habitacion no disponible");


                }
                else
                {
                    Reserva reserva = new Reserva(id, habitacionID, FechaE, FechaS, fechaHoy, usuariologueado, habitacion);
                    hotel1.AgregarReserva(reserva);
                    hotel1.ListarReservas(id);

                }






                // Ofrecer la opción de realizar otra reserva
                Console.WriteLine("¿Deseas realizar otra reserva? (si/no): ");
                string respuesta = Console.ReadLine()?.Trim().ToLower();
                if (respuesta == "si")
                {
                    IngresarNuevaReserva(); // Llamar de nuevo al método si el usuario desea hacer otra reserva
                }
                else { Console.WriteLine("Gracias por elegirnos"); }
            }


            void ListarHabitaciones()
            {

                Console.WriteLine("Habitaciones: ");
                if (hotel1.habitaciones.Count == 0)
                {
                    Console.WriteLine("No hay habitaciones");
                }
                else
                {
                    hotel1.ListarHabitaciones();
                }
            }

             void ListarHabitacionesDisponibles()
            {

                var habitaciones = hotel1.ListarHabitacionesDisponibles();

                foreach (var habitacion in habitaciones)
                {
                    Console.WriteLine(habitacion);
                }
            }

            void ListarHabitacionesPorFecha()
            {
                Console.Write("Elija fecha de entrada (D/M/A): ");
                DateTime FechaE = DateTime.Parse(Console.ReadLine());
                Console.Write("Elija fecha de salida (D/M/A): ");
                DateTime FechaS = DateTime.Parse(Console.ReadLine());

                List<Habitacion> habitaciones = hotel1.habitaciones;
                foreach (Habitacion habitacion in habitaciones)
                {
                    bool estaReservada = ChequearDisponibilidad(habitacion, FechaE, FechaS);
                    if (!estaReservada)
                    {
                        Console.WriteLine(habitacion);

                   }
                    
                }

            }

            int IdReserva()
            {
                List<Reserva> reservas = hotel1.reservas;
                int id = 1;
                if (reservas.Count != 0)
                {
                    id = reservas.Count+1;
                }
                return id;
            }

            Habitacion BuscarHabitacionPorId( int id)
            {
                List <Habitacion> habitaciones = hotel1.habitaciones;
                Habitacion habitacion = null; 
                foreach(Habitacion hab in habitaciones)
                {
                    if(hab.idNumeroHabitacion == id)
                    {
                        habitacion = hab;
                    }
                }
                return habitacion;
            }
            
           
            {

              





            }

            



        }




    }
    }

    

