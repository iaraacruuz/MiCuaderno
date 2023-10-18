using MiCuaderno;

namespace Interfaz
{
    public partial class MostrarComunicaciones : Form
    {
        List<Comunicacion> listaComunicaciones = new List<Comunicacion>();



        public MostrarComunicaciones()
        {
            InitializeComponent();

            //this.listaComunicaciones = new List<Comunicacion>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        private void SetDGV(DataGridView dataGridView2)
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoResizeColumns();
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView2.DefaultCellStyle.BackColor = Color.White;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToResizeColumns = false;
        }
        private void MostrarComunicaciones_Load(object sender, EventArgs e)
        {

            Comunicacion comunicacion1 = new Comunicacion("Reunión de padres", "La reunión de padres se llevará a cabo el próximo martes a las 18:00.", DateTime.Now);




            //Crear una comunicación y agregarla a la lista


            listaComunicaciones.Add(comunicacion1);
            MessageBox.Show("Número de elementos en la lista: " + listaComunicaciones.Count);

            //MessageBox.Show("Formulario cargado");
            // Agregar más comunicaciones si es necesario

            // Ahora, puedes cargar la lista de comunicaciones en tu DataGridView

            dataGridView2.AutoGenerateColumns = true;
            /*dataGridView2.Columns.Add("Asunto", "Asunto");
            dataGridView2.Columns.Add("Mensaje", "Mensaje");
            dataGridView2.Columns.Add("FechaEnvio", "Fecha de Envío");*/

            dataGridView2.DataSource = listaComunicaciones;
            SetDGV(dataGridView2);

            /////////////////////////////////////////////////////////////////////////////

            /* Comunicacion comunicacion1 = new Comunicacion("Reunión de padres", "La reunión de padres se llevará a cabo el próximo martes a las 18:00.", DateTime.Now);

             listaComunicaciones.Add(comunicacion1);
             //dataGridView1.AutoGenerateColumns = false;
             // Verificar si la lista tiene datos antes de asignarla al DataGridView
             MessageBox.Show("La lista de comunicaciones está vacía.");

             if (listaComunicaciones != null && listaComunicaciones.Count > 0)
             {

                 dataGridView2.AutoGenerateColumns = false;
                 // Asignar las columnas manualmente
                 dataGridView2.Columns.Add("Asunto", "Asunto");
                 dataGridView2.Columns.Add("Mensaje", "Mensaje");
                 dataGridView2.Columns.Add("FechaEnvio", "Fecha de Envío");

                 // Asignar la lista de comunicaciones al DataGridView

                 dataGridView2.DataSource = listaComunicaciones;
             }
             else
             {
                 // La lista está vacía o es nula, así que muestra un mensaje o realiza alguna acción apropiada.
                 MessageBox.Show("La lista de comunicaciones está vacía.");
             }

             // Crear una comunicación y agregarla a la lista*/

        }
    }
}
