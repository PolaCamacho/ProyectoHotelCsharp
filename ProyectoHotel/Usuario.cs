using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class Usuario
    {
       
        
        public  string Email {  get; set; }
        public object contrasenia { get; set; }

        public List<Usuario> usuario { get; set; }
        

        public Usuario(string idEmail, object contrasenia) {

           this.Email = idEmail;
            this.contrasenia =  contrasenia;
            usuario = new List<Usuario>();



        }
        public  string ToString()
        {
            return $" Email {Email}, contraseña {contrasenia}";

        }

      

    }
}
