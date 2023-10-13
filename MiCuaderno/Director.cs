using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCuaderno
{
    public class Director: Persona
    {
        public string Titulo { get; set; }

        public Director(string nombre, string apellido, string correoElectronico, string titulo)
            : base(nombre, apellido, correoElectronico)
        {
            Titulo = titulo;
        }
        // Método para registrar sanciones a un alumno
        public void RegistrarSancionAlumno(Alumno alumno, string motivo, DateTime fecha)
        {
            // Lógica para registrar sanciones o medidas disciplinarias
        }

        // Método para planificar reuniones con padres
        public void PlanificarReunionPadres(Alumno alumno, DateTime fecha, string tema)
        {
            // Lógica para coordinar reuniones con padres de alumnos
        }

        // Método para crear eventos escolares
        public void CrearEventoEscolar(string nombreEvento, DateTime fecha)
        {
            // Lógica para definir eventos en el calendario escolar
        }

        // Método para enviar comunicaciones a la comunidad escolar
        public void EnviarComunicaciones(string mensaje)
        {
            // Lógica para enviar mensajes a la comunidad escolar
        }

        // Método para generar un informe del estado de la institución
        public void GenerarInformeEstadoInstitucion()
        {
            // Lógica para producir informes sobre el estado general de la institución
        }
    }
}
