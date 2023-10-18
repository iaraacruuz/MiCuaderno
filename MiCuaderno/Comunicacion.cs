using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCuaderno
{
    public class Comunicacion
    {
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }

        public Comunicacion(string asunto, string mensaje, DateTime fechaEnvio)
        {
            Asunto = asunto;
            Mensaje = mensaje;
            FechaEnvio = fechaEnvio;
        }

    }

}
