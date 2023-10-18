using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCuaderno
{
    public class Padre : Persona
    {
        public string NumeroContacto { get; set; }
        public List<Alumno> Hijos { get; set; }

        public Padre(string nombre, string apellido, string correoElectronico,string clave, string numeroContacto)
           : base(nombre, apellido, correoElectronico, clave)
        {
            NumeroContacto = numeroContacto;
            Hijos = new List<Alumno>(); // Inicializa la lista de hijos en el constructor.
        }

        public void VerHijos()
        {
            // Implementa la lógica para mostrar información sobre los hijos del padre.
            // Puedes acceder a los hijos (alumnos) a través de la lista de alumnos en la clase Persona.
            // Por ejemplo:
            foreach (Alumno hijo in Hijos)
            {
                Console.WriteLine($"Hijo: {hijo.Nombre} {hijo.Apellido}");
            }
        }
    }
}
