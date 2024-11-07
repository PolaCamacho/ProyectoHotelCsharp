using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class Habitacion
    {

        public int idNumeroHabitacion {  get; set; }
        public string tipoHabitacion { get; set; }

        public int cantidadHuesped { get; set; }

        public int precioDiario { get; set; }

        public bool disponible { get; set; }

        

         public Habitacion( int idNumeroHabitacion, string tipoHabitacion, int cantidadHuesped, int precioDiario)
        {
            this.idNumeroHabitacion = idNumeroHabitacion;
            this.tipoHabitacion = tipoHabitacion;
            this.cantidadHuesped = cantidadHuesped;
            this.precioDiario = precioDiario;
            
            disponible = true;

        }

        public override string ToString()
        {
            return $"Habitacion: {idNumeroHabitacion} Tipo: {tipoHabitacion} Cantidad: {cantidadHuesped}, Precio {precioDiario}";


        }

      

    }
}
