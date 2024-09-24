using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCasaApuestas
{
    internal class clsRegistrarse
    {

        public string strNombre { get; set; }
        public string strApellido { get; set; }
        public int intEdad { get; set; }
        public int intCedula { get; set; }
        public string strCorreo { get; set; }
        public string strUsuario { get; set; }
        public string strContraseña { get; set; }
        public string strConfirmacionContraseña { get; set; }

        public int  intMonto { get; set; }

        public clsRegistrarse()
        { }

        public clsRegistrarse(string strNombre, string strApellido, int intEdad, int intCedula, string strCorreo, string strUsuario, string strContraseña, string strConfirmacionContraseña)
        {
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.intEdad = intEdad;
            this.intCedula = intCedula;
            this.strCorreo = strCorreo;
            this.strUsuario = strUsuario;
            this.strContraseña = strContraseña;
            this.strConfirmacionContraseña = strConfirmacionContraseña;
        }

        public bool insertarDatoRegistro()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();

            string insertar = "insert into tblRegistrarse values (@strNombre, @strApellido, @intEdad, @intCedula, @strCorreo,@strUsuario, @strContraseña, @strConfirmacionContraseña)";
           
            SqlCommand sql = new SqlCommand(insertar, conexion);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@intEdad", this.intEdad);
            sql.Parameters.AddWithValue("@intCedula", this.intCedula);
            sql.Parameters.AddWithValue("@strCorreo", this.strCorreo);
            sql.Parameters.AddWithValue("@strUsuario", this.strUsuario);
            sql.Parameters.AddWithValue("@strContraseña", this.strContraseña);
            sql.Parameters.AddWithValue("@strConfirmacionContraseña", this.strConfirmacionContraseña);
            sql.ExecuteNonQuery();

            return true;
   
        }
     

        public DataTable consultarDatoRegistrarse(int intCedula)

        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();


            DataTable dt = new DataTable();
            this.intCedula = intCedula;
            string consulta = "select * from tblRegistrarse where intCedula = @intCedula";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@intCedula", this.intCedula);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        public bool eliminarDatoRegistrarse(int intCedula)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
                conexion.Open();

                this.intCedula = intCedula;
                string eliminar = "delete tblRegistrarse where intCedula = @intCedula";
                SqlCommand sql = new SqlCommand(eliminar, conexion);
                sql.Parameters.AddWithValue("@intCedula", this.intCedula);
                sql.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool modificarDatoRegistrarse()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();
            
            string insertar = "update tblRegistrarse set strNombre = @strNombre ,strApellido = @strApellido , intEdad = @intEdad, strCorreo = @strCorreo, strUsuario = @strUsuario, strContraseña = @strContraseña, strConfirmacionContraseña = @strConfirmacionContraseña";
            SqlCommand sql = new SqlCommand(insertar, conexion);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@intEdad", this.intEdad); 
            sql.Parameters.AddWithValue("@strCorreo", this.strCorreo);
            sql.Parameters.AddWithValue("@strUsuario", this.strUsuario);
            sql.Parameters.AddWithValue("@strContraseña", this.strContraseña);
            sql.Parameters.AddWithValue("@strConfirmacionContraseña", this.strConfirmacionContraseña);


            sql.ExecuteNonQuery();


            return true;
        }



        public DataTable seleccionarDatoRegistrarse()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuestadatabase=dboCasaApuesta; integrated security = true ");
            conexion.Open();

            this.intCedula = intCedula; 
            DataTable dt = new DataTable();
            string seleccionar = "select * from tblRegistrarse  where intCedula = @intCedula";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intCedula", this.intCedula);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;



        }

        
    }
}
