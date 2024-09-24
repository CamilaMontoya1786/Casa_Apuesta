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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registrarse FrmRegistrarse = new Registrarse();
            FrmRegistrarse.Show();
        }

        private void linkOlvidoContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lo sentimos mucho, contactate con el area de sistemas");
        }

        public void Buscar(string strUsuario, string strContraseña)
        {

            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT strNombre FROM tblregistrarse WHERE strUsuario = @strUsuario AND strContraseña = @strContraseña", conexion);
                cmd.Parameters.AddWithValue("@strUsuario", strUsuario);
                cmd.Parameters.AddWithValue("@strContraseña", strContraseña);
                //Se crea un nuevo objeto para pasarle los comandos 
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    MenuPrincipal Menu = new MenuPrincipal();
                    Menu.Show();

                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseñas son incorrectos, vuelva a intentarlo.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { conexion.Close(); }


        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Buscar(txtUsuario.Text, txtContraseña.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
    
