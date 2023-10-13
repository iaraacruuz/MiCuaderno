using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCuaderno
{
    public class Alumno: Persona
    {
        public int NumeroLegajo { get; set; }
        public List<Asistencia> RegistroAsistencias { get; }

        public Alumno(string nombre, string apellido, string correoElectrónico, int numeroLegajo)
        : base(nombre, apellido, correoElectrónico)
        {
            NumeroLegajo = numeroLegajo;
        }

        public void RegistrarAsistencia(Asistencia asistencia)
        {
            // Agregar lógica para registrar asistencia aquí
            // Por ejemplo, podrías agregar la asistencia a una lista de asistencias del alumno.

            // Agregar la asistencia al registro del alumno
            RegistroAsistencias.Add(asistencia);
        }
    }
}
