using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class PagoEfectivo : Pago // Pago en efectivo
    {
        public decimal CambioEntregado { get; set; }

        // Constructor que llama al constructor base
        public PagoEfectivo(int idPago, int idReserva, DateTime fechaPago, decimal monto, string tipoPago, decimal cambioEntregado)
            : base(idPago, idReserva, fechaPago, monto, tipoPago)
        {
            CambioEntregado = cambioEntregado;
        }
    }
}
