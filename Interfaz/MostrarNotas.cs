using MiCuaderno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MostrarNotas : Form
    {
        List<Nota> listaNotas = new List<Nota>();

        public MostrarNotas()
        {
            InitializeComponent();

        }

        private void MostrarNotas_Load(object sender, EventArgs e)
        {
            Nota nota1 = new Nota("Matemáticas", 9.5);
            listaNotas.Add(nota1);

            // Puedes agregar más notas si es necesario

            // Configurar el DataGridView
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = listaNotas;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
