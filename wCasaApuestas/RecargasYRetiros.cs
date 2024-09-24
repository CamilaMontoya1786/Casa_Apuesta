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
    public partial class RecargasYRetiros : Form
    {
        public RecargasYRetiros()
        {
            InitializeComponent();
        }

     

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
                conexion.Open();
                clsRetiroYRecarga retirar = new clsRetiroYRecarga(Convert.ToInt32(txtCedula.Text), Convert.ToInt32(txtMonto.Text));
                retirar.Retiro(Convert.ToInt32(txtCedula.Text));

                MessageBox.Show("Su retiro a sido solicitado exitosamente, puede acercarse a cualquier sucursal a realizar el reclamo.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar su retiro" + ex);
            }

        }

      

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
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

        private void btnRecargar_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
                conexion.Open();
                clsRetiroYRecarga recargar = new clsRetiroYRecarga(Convert.ToInt32(txtCedula.Text), Convert.ToInt32(txtMonto.Text));
                recargar.Recarga(Convert.ToInt32(txtCedula.Text));
                MessageBox.Show("Su recarga a sido exitosa.");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar su recarga" + ex);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                txtMonto.Text = "";
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS; database=dboCasaApuesta; integrated security = true ");
                conexion.Open();
                clsRetiroYRecarga consulta = new clsRetiroYRecarga();

                dtgSaldo.DataSource = consulta.consultarDatoSaldo(Convert.ToInt32(txtCedula.Text));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar el saldo " + ex);
            }
        }

        private void RecargasYRetiros_Load(object sender, EventArgs e)
        {

        }
    }
}
