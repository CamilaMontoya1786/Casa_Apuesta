using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCasaApuestas
{
    public partial class AtencionAlCliente : Form
    {
        public AtencionAlCliente()
        {
            InitializeComponent();
        }


     

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Hide();


            Form1 InicioSesion = new Form1();
            InicioSesion.Show();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
       
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Fecha = DateTime.Today;

                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
                conexion.Open();


                clsAtencionAlCliente enviar = new clsAtencionAlCliente(Convert.ToInt32(txtCedula.Text), txtAsunto.Text, Convert.ToDateTime(Fecha), txtMensaje.Text);

                enviar.enviarSolicitud();
                MessageBox.Show("Su solicitu ha sido enviada ");



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al enviar su solicitud, asegurese de llenar e ingresar correctamente todos los campos " + ex);

            }

        }
    }
}
