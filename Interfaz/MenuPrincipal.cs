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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cOMUNICACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarComunicaciones nc = new MostrarComunicaciones();
            nc.MdiParent = this; // Establece el MdiParent como el formulario principal
            nc.Show();

        }

        private void nOTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarNotas mc = new MostrarNotas();
            mc.MdiParent = this;
            mc.Show();
        }

        private void cALENDARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
