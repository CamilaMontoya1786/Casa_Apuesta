using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCasaApuestas
{
    internal class clsAtencionAlCliente
    {
        public int intCedula { get; set; }
        public string strAsunto { get; set; }

        public DateTime datFecha { get; set; }

        public string strMensaje { get; set; }


        public clsAtencionAlCliente()
        { }

        public clsAtencionAlCliente(int intCedula, string strAsunto, DateTime datFecha, string strMensaje)
        {

            this.intCedula = intCedula;
            this.strAsunto = strAsunto;
            this.datFecha = datFecha;
            this.strMensaje = strMensaje;

        }

        public bool enviarSolicitud()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();

            string insertar = "insert into tblAtencionAlCliente values (@intCedula, @strAsunto,@datFecha, @strMensaje)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCedula", this.intCedula);
            sql.Parameters.AddWithValue("@strAsunto", this.strAsunto);
            sql.Parameters.AddWithValue("@datFecha", this.datFecha);
            sql.Parameters.AddWithValue("@strMensaje", this.strMensaje);

            sql.ExecuteNonQuery();
            return true;
        }

    }
}
