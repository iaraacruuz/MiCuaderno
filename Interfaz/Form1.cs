using MiCuaderno;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //se puede poner condicion al apretar boton de cerrar, ya sea estar seguro de cerrar o guardar archivo etc.
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*
            //this porque se hace refernecia a este formulario
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;
            //COSAS A AGREGAR:
            // ej tenerr una coleccion de usuarios en algun archivo, etenr hardcodeado un archivo en una clase estatica de una
            //base de datos,verificar la identidad de su usuario.

            // Verifica que el usuario y la contrase�a cumplan con los requisitos m�nimos
            if (usuario.Length >= 3 && clave.Length >= 3)
            {
                // Coloca aqu� la contrase�a y el usuario deseados
                string usuarioValido = "admin";
                string claveValida = "123";

                if (usuario == usuarioValido && clave == claveValida)
                {
                    //MessageBox.Show("Inicio de sesi�n exitoso","Log in",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Puedes agregar aqu� el c�digo para abrir el siguiente formulario o realizar acciones posteriores.
                    VentanaEmergente ve = new VentanaEmergente("Log in", "Inicio de Sesi�n exitoso");
                    ve.ShowDialog();

                    if (ve.DialogResult == DialogResult.OK)
                    {
                        MenuPrincipal mp = new MenuPrincipal();
                        mp.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contrase�a incorrectos. Por favor, int�ntelo nuevamente", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El usuario y la contrase�a deben tener al menos 3 caracteres.");
            }*/


            /////////////////////////////////////////////////////////////////////////////////////////////////

            // Obt�n el usuario y la contrase�a ingresados por el usuario
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;

            // Verifica que el usuario y la contrase�a cumplan con los requisitos m�nimos
            if (usuario.Length >= 3 && clave.Length >= 3)
            {
                // Coloca aqu� la contrase�a y el usuario deseados
                string usuarioValido = "admin";
                string claveValida = "123";

                if (usuario == usuarioValido && clave == claveValida)
                {
                    // Registro de inicio de sesi�n exitoso
                    MessageBox.Show("Inicio de sesi�n exitoso", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Guardar el registro de inicio de sesi�n
                    List<RegistroInicioSesion> registros = new List<RegistroInicioSesion>();
                    registros.Add(new RegistroInicioSesion(usuario, clave)); // Puedes personalizar la informaci�n del registro

                    string rutaArchivo = "registrosSesion.xml";
                    RegistroInicioSesion.GuardarRegistrosSesion(registros, rutaArchivo);

                    // Puedes agregar aqu� el c�digo para abrir el siguiente formulario o realizar acciones posteriores.
                    VentanaEmergente ve = new VentanaEmergente("Log in", "Inicio de Sesi�n exitoso");
                    ve.ShowDialog();

                    if (ve.DialogResult == DialogResult.OK)
                    {
                        MenuPrincipal mp = new MenuPrincipal();
                        mp.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contrase�a incorrectos. Por favor, int�ntelo nuevamente", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El usuario y la contrase�a deben tener al menos 3 caracteres.");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}