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
    public partial class Apuestas : Form
    {
        public Apuestas()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal Menu= new MenuPrincipal();
            Menu.Hide();

            Form1 InicioSesion = new Form1();
            InicioSesion.Show(); this.Hide();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void btnConsultarDeporte_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS; database=dboCasaApuesta; integrated security = true ");
                conexion.Open();
                clsApuesta consulta = new clsApuesta();
                dtgDeporte.DataSource = consulta.consultarDeporte();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar el dato" + ex);
            }
        }

        private void dtgApuesta_MouseClick(object sender, MouseEventArgs e)
        {
            txtIntDeporte.Text = dtgDeporte.SelectedRows[0].Cells[0].Value.ToString();
            txtDeporte.Text = dtgDeporte.SelectedRows[0].Cells[1].Value.ToString();
        }



        private void btnConsultarEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS; database=dboCasaApuesta; integrated security = true ");
                conexion.Open();
                clsApuesta consulta = new clsApuesta();
                dtgEquipos.DataSource = consulta.consultarEquipo(Convert.ToInt16(txtIntDeporte.Text));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar el dato" + ex);
            }
        }

        private void dtgEquipos_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombreEquipo.Text= dtgEquipos.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnConsultarPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS; database=dboCasaApuesta; integrated security = true ");
                conexion.Open();
                clsApuesta consulta = new clsApuesta();
                dtgPartidos.DataSource = consulta.consultarPartidos(txtNombreEquipo.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar el dato" + ex);
            }
        }

        private void dtgPartidos_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombreE.Text = dtgPartidos.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreR.Text = dtgPartidos.SelectedRows[0].Cells[1].Value.ToString();
            txtPaga.Text = dtgPartidos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnRealizarApuesta_Click(object sender, EventArgs e)
        {
            

            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
                conexion.Open();

               
                    clsApuesta insertar = new clsApuesta(Convert.ToInt32(txtCedula.Text), txtNombreE.Text, txtNombreR.Text, Convert.ToInt32(txtPaga.Text), Convert.ToInt32(txtMontoApuesta.Text));
                    insertar.insertarDatosApuesta(Convert.ToInt32(txtCedula.Text));
                    




                MessageBox.Show("Su apuesta ha sido generada exitosamente. Tendrá la oportunidad de ganar: " + Convert.ToInt32(txtPaga.Text) * Convert.ToInt32(txtMontoApuesta.Text) + "¡Mucha suerte!");





            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar la apuesta." + ex);

            }
        }

        private void Apuestas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
