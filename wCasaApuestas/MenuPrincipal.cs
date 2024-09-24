using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCasaApuestas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Declarar una variable para almacenar el formulario hijo actual
        private Form formularioHijoActual = null;

        // Método para mostrar formularios hijos y ocultar el actual
        private void MostrarFormularioHijo(Form nuevoFormularioHijo)
        {
            // Si ya hay un formulario hijo abierto, ocúltalo
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Hide();  // Oculte el formulario anterior
            }

            // Asignar el nuevo formulario como hijo actual
            formularioHijoActual = nuevoFormularioHijo;
            formularioHijoActual.MdiParent = this; // Establecer el MDI Parent
            formularioHijoActual.Show();  // Mostrar el nuevo formulario
        }

        // Evento al hacer clic en "Recargas y Retiros"
        private void recargasYRetirosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RecargasYRetiros frmRecargasYRetiros = new RecargasYRetiros();
            MostrarFormularioHijo(frmRecargasYRetiros);  // Mostrar el formulario
        }

        // Evento al hacer clic en "Apuestas"
        private void apuestasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Apuestas frmApuestas = new Apuestas();
            MostrarFormularioHijo(frmApuestas);  // Mostrar el formulario
        }

        // Evento al hacer clic en "Atención al Cliente"
        private void atenciónAlClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AtencionAlCliente frmAtencionAlCliente = new AtencionAlCliente();
            MostrarFormularioHijo(frmAtencionAlCliente);  // Mostrar el formulario
        }

        // Evento para salir del programa
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();  // Cerrar el formulario principal
        }


        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
