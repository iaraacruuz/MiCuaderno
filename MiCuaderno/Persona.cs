using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MiCuaderno
{
    public class Persona
    {


        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Clave { get; set; }
        

        public List<Nota> Notas { get; set; }
        public List<Comunicacion> ComunicacionesEnviadas { get; set; }
        public List<Comunicacion> ComunicacionesRecibidas { get; set; }
        public List<Asistencia> Asistencias { get; set; }

        // Constructor para inicializar una instancia de Persona
        public Persona(string nombre, string apellido, string correoElectronico, string clave)
        {
            Nombre = nombre;
            Apellido = apellido;
            CorreoElectronico = correoElectronico;
            Clave = clave;
            
            Notas = new List<Nota>();
            ComunicacionesEnviadas = new List<Comunicacion>();
            ComunicacionesRecibidas = new List<Comunicacion>();
            Asistencias = new List<Asistencia>();
            
        }

        // Método para agregar una nota
        public void AgregarNota(Nota nota)
        {
            Notas.Add(nota);
        }

        // Método para escribir una comunicación
        public void EscribirComunicacion(Comunicacion comunicacion)
        {
            ComunicacionesEnviadas.Add(comunicacion);
        }

        // Método para obtener las asistencias
        public List<Asistencia> ObtenerAsistencias()
        {
            return Asistencias;
        }

        // Método para mostrar información de la persona
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Correo Electrónico: {CorreoElectronico}");
        }

        // Método para mostrar las notas
        public void VerNotas()
        {
            foreach (var nota in Notas)
            {
                Console.WriteLine($"Asignatura: {nota.Asignatura}, Nota: {nota.Valor}");
            }
        }
    }
}
