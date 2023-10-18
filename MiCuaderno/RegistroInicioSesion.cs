using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace MiCuaderno
{
    [Serializable]

    public class RegistroInicioSesion
    {
       

        public string usuario { get; set; }
        public string clave { get; set; }
        public DateTime Fecha { get; set; }

        public RegistroInicioSesion()
        {
            // Constructor sin parámetros requerido para la serialización XML.
        }

        public RegistroInicioSesion(string NombreUsuario, string Clave)
        {
            usuario = NombreUsuario;
            clave = Clave;
            Fecha = DateTime.Now;
        }

        public static void GuardarRegistrosSesion(List<RegistroInicioSesion> registros, string rutaArchivo)
        {
            using (FileStream fileStream = new FileStream(rutaArchivo, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<RegistroInicioSesion>));
                serializer.Serialize(fileStream, registros);
            }
        }

        public static List<RegistroInicioSesion> CargarRegistrosSesion(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                using (FileStream fileStream = new FileStream(rutaArchivo, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<RegistroInicioSesion>));
                    return (List<RegistroInicioSesion>)serializer.Deserialize(fileStream);
                }
            }
            else
            {
                return new List<RegistroInicioSesion>();
            }
        }

    }
}
