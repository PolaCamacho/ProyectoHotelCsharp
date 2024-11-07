using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class Pago
    {
        public int idPago { get; set; }
        public DateTime fechaPago { get; set; }
        public decimal monto { get; set; }
        public string tipoPago { get; set; }



        public Pago(int idPago, int idReserva, DateTime fechaPago, decimal monto, string tipoPago)

        {
            this.idPago = idPago;
            this.fechaPago = fechaPago;
            this.monto = monto;
            this.tipoPago = tipoPago;
        }
    }

       
    }

