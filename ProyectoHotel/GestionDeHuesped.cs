using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class GestionDeHuesped
    {
        public List<Huesped> CargarHuesped()
        {
            List<Huesped> personas = new List<Huesped>();

            
            personas.Add(new Huesped(1, "Fernando", "Gonzales", "CI", 48590224, 099432569, "goto@gmail.com", "Argentina"));
            personas.Add(new Huesped(2, "Lucía", "Martínez", "CI", 12345678, 099876543, "lucia@example.com", "Argentina"));
            personas.Add(new Huesped(3, "Carlos", "Pérez", "CI", 87654321, 099112233, "carlos@example.com", "Argentina"));
            personas.Add(new Huesped(4, "Ana", "Lopez", "CI", 98765432, 099223344, "ana@example.com", "Argentina"));
            personas.Add(new Huesped(5, "Juan", "Sanchez", "CI", 65432178, 099334455, "juan@example.com", "Argentina"));

            return personas;
        }

    }
}
