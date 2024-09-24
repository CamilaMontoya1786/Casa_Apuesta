using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCasaApuestas
{
    internal class clsRetiroYRecarga
    {


        public int intCedula { get; set; }
        public int intMonto { get; set; }

        public clsRetiroYRecarga()
        { }

        public clsRetiroYRecarga(int intCedula, int intMonto)
        {

            this.intCedula = intCedula;
            this.intMonto = intMonto;

        }

        public bool Recarga(int intCedula)
        {
         
                using (SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true"))
                {
                    conexion.Open();

                    // Primero intentamos actualizar el monto
                    string updateQuery = "UPDATE tblRecargaRetiro SET intMonto = intMonto + @intMonto WHERE intCedula = @intCedula";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, conexion))
                    {
                        updateCommand.Parameters.AddWithValue("@intCedula", intCedula);
                        updateCommand.Parameters.AddWithValue("@intMonto", this.intMonto); // Monto a sumar

                        int rowsAffected = updateCommand.ExecuteNonQuery(); // Ejecuta la actualización

                        if (rowsAffected == 0) // Si no se actualizó, significa que no existía el registro
                        {
                            // Hacemos la inserción
                            string insertQuery = "INSERT INTO tblRecargaRetiro (intCedula, intMonto) VALUES (@intCedula, @intMonto)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, conexion))
                            {
                                insertCommand.Parameters.AddWithValue("@intCedula", intCedula);
                                insertCommand.Parameters.AddWithValue("@intMonto", this.intMonto); // El monto a insertar

                                insertCommand.ExecuteNonQuery(); // Ejecuta la inserción
                            }
                        }
                    }
                }

                return true; // Indica que la operación se completó exitosamente
            }

        
        public bool Retiro(int intCedula)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true"))
                {
                    conexion.Open();

                    // Actualiza el monto restando el intMonto actual
                    string recargar = "UPDATE tblRecargaRetiro SET intMonto = intMonto - @intMonto WHERE intCedula = @intCedula";
                    using (SqlCommand sql = new SqlCommand(recargar, conexion))
                    {
                        sql.Parameters.AddWithValue("@intCedula", intCedula); // Cedula para identificar el registro
                        sql.Parameters.AddWithValue("@intMonto", this.intMonto); // Monto a restar

                        int rowsAffected = sql.ExecuteNonQuery(); // Ejecuta la actualización

                        // Verifica si se afectó alguna fila
                        if (rowsAffected == 0)
                        {
                            // Opcional: manejar el caso donde no se encontró el registro
                            Console.WriteLine("No se encontró un registro con la cédula especificada.");
                            return false; // No se encontró el registro para restar el monto
                        }
                    }
                }

                return true; // Indica que la operación se completó exitosamente
            }
            catch (SqlException sqlEx)
            {
                // Manejo de errores específicos de SQL
                Console.WriteLine($"Error en la base de datos: {sqlEx.Message}");
                return false;
            }
            catch (FormatException)
            {
                // Manejo específico para errores de formato, como números no válidos
                Console.WriteLine("Verifica que estás ingresando valores numéricos válidos.");
                return false;
            }
            catch (OverflowException)
            {
                // Manejo específico para desbordamiento
                Console.WriteLine("El valor ingresado es demasiado grande o demasiado pequeño.");
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                Console.WriteLine($"Se produjo un error: {ex.Message}");
                return false;
            }
        }

        public DataTable consultarDatoSaldo(int intCedula)
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();


            DataTable dt = new DataTable();
            this.intCedula = intCedula;
            string consulta = "select * from tblRecargaRetiro where intCedula = @intCedula";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@intCedula", this.intCedula);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
