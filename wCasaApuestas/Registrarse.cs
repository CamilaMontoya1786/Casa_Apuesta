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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 FrmInicioSesion = new Form1();
            FrmInicioSesion.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtConfirmacionContraseña.Text = "";
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            txtEdad.Text = "";
            txtCedula.Text = "";
            txtCorreo.Text = "";
               
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
                conexion.Open();

                if (txtContraseña.Text==txtConfirmacionContraseña.Text)
                {
                    clsRegistrarse insertar = new clsRegistrarse(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtCedula.Text), txtCorreo.Text, txtUsuario.Text, txtContraseña.Text, txtConfirmacionContraseña.Text);
                    insertar.insertarDatoRegistro();
                    
                    

                    MessageBox.Show("El dato ha sido ingresado");
                    
                }
                else
                {
                    MessageBox.Show("Recuerda que la contraseña y la confirmación de la contraseña deben ser iguales.");
                }

                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar el dato" + ex);

            }
           

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS; database=dboCasaApuesta; integrated security = true ");
                conexion.Open();
                clsRegistrarse consulta = new clsRegistrarse();
                dtgRegistrarse.DataSource = consulta.consultarDatoRegistrarse(Convert.ToInt32(txtCedula.Text));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar el dato" + ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
                conexion.Open();

                clsRegistrarse modificar = new clsRegistrarse(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtCedula.Text), txtCorreo.Text,txtUsuario.Text, txtContraseña.Text, txtConfirmacionContraseña.Text);

                modificar.modificarDatoRegistrarse();
                MessageBox.Show("Sus datos han sido modificados exitosamente.");

                dtgRegistrarse.DataSource = modificar.consultarDatoRegistrarse(Convert.ToInt32(txtCedula.Text));



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar dato" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
                conexion.Open();

               clsRegistrarse eliminar= new clsRegistrarse();
                eliminar.eliminarDatoRegistrarse(Convert.ToInt32(txtCedula.Text));
                dtgRegistrarse.DataSource = eliminar.consultarDatoRegistrarse(Convert.ToInt32(txtCedula.Text));

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgRegistrarse_MouseClick(object sender, MouseEventArgs e)
        {
            //Va a tomar la tabla como un array y va a seleccionar todo desde la fila cero y me lo evalue como string
            txtNombre.Text = dtgRegistrarse.SelectedRows[0].Cells[0].Value.ToString();
            txtApellido.Text = dtgRegistrarse.SelectedRows[0].Cells[1].Value.ToString();
            txtEdad.Text = dtgRegistrarse.SelectedRows[0].Cells[2].Value.ToString();
            txtCedula.Text = dtgRegistrarse.SelectedRows[0].Cells[3].Value.ToString();
            txtCorreo.Text = dtgRegistrarse.SelectedRows[0].Cells[4].Value.ToString();
            txtUsuario.Text= dtgRegistrarse.SelectedRows[0].Cells[5].Value.ToString();
            txtContraseña.Text = dtgRegistrarse.SelectedRows[0].Cells[6].Value.ToString();
            txtConfirmacionContraseña.Text = dtgRegistrarse.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 InicioSesion = new Form1();
            InicioSesion.Show();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
 }

