using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCuaderno
{
    public class Nota
    {

        public string Asignatura { get; set; }
        public double Valor { get; set; }

        public Nota(string asignatura, double valor)
        {
            Asignatura = asignatura;
            Valor = valor;
        }
    }
}
