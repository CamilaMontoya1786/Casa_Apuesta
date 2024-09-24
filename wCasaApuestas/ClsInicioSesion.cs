using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCasaApuestas
{
    internal class clsInicioSesion
    {
        public string mensaje;
        public string strUsuario { get; set; }
        public string strContraseña { get; set; }

        public clsInicioSesion()
        { }
       
    }
}
