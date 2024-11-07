using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class Huesped 
    {
        public int idHuesped { get; set; }
        public string nombreHuesped { get; set; }
        public string apellidoHuesped { get; set; }

        public string tipoDocHuesped { get; set; }
        public double  documentoNHues {  get; set; }
        

        public int numeroCelHues { get; set; }

        public string emailHues {  get; set; }

        public string paisHues { get; set; }

        public List<Usuario> usuario { get; set; }



        public Huesped( int idHuesped, string nombreHuesped,string apellidoHuesped, string tipoDocHuesped,
            double documentoNHues,  int numeroCelHues, string emailHues, string paisHues)
        {
            this.idHuesped = idHuesped;
            this.nombreHuesped = nombreHuesped;
            this.apellidoHuesped = apellidoHuesped;
            this.tipoDocHuesped = tipoDocHuesped;
            this.documentoNHues = documentoNHues;
            
            this.numeroCelHues = numeroCelHues;
            this.emailHues = emailHues;
           this.paisHues = paisHues;
            
                

        }

       
        public override string ToString()
        {
           return $" ID : {idHuesped} Nombre: {nombreHuesped}, Apellido: {apellidoHuesped}, Documento: {tipoDocHuesped}, Nro Doc: {documentoNHues}, Celular: {numeroCelHues}, Email {emailHues},Pais {paisHues}";

        }

    }
}
