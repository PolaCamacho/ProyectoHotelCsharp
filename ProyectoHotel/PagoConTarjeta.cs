using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class PagoConTarjeta : Pago //pago con tarjeta
                                         {
       

           
            
                public int NumeroTarjeta { get; set; }
                public string TipoTarjeta { get; set; } // Credito o Debito

                // Constructor que llama al constructor base y agrega detalles específicos de la tarjeta
                public PagoConTarjeta(int idPago, int idReserva, DateTime fechaPago, decimal monto, string tipoPago, int numeroTarjeta, string tipoTarjeta)
                    : base(idPago, idReserva, fechaPago, monto, tipoPago)
                {
                    NumeroTarjeta = numeroTarjeta;
                    TipoTarjeta = tipoTarjeta;
                }
            }
        
    
    
}
