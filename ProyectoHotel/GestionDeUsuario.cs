using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoHotel;

namespace ProyectoHotel
{
    internal class GestionDeUsuario
    {

        public List<Usuario> CargarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario("Fernandez@gmail.com", 1234567));
            usuarios.Add(new Usuario("Lucas@gmail.com", "Contra67"));
            usuarios.Add(new Usuario("Juancho@gmail.com", "UwU"));

            return usuarios;
        }


        

    }
}


   
