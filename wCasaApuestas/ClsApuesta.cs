using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCasaApuestas
{
    internal class clsApuesta
    {
   

        public int intDeporte { get; set; }
        public int intCedula { get; set; }
        public string strNombreEquipo { get; set; }
        public string strRival { get; set; }
        public int intValorAPagar { get; set; }
        public int intMontoApuesta { get; set; }

        public clsApuesta() { }
        public clsApuesta(int intCedula, string strNombreEquipo, string strRival, int intValorAPagar, int intMontoApuesta)
        {
            this.intCedula = intCedula;
            this.strNombreEquipo = strNombreEquipo;
            this.strRival = strRival;
            this.intValorAPagar = intValorAPagar;
            this.intMontoApuesta = intMontoApuesta;
        }


        public DataTable consultarDeporte()

        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();


            DataTable dt = new DataTable();
            string consulta = "select * from tblDeporte";
            SqlCommand cmd = new SqlCommand(consulta, conexion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable consultarEquipo(int intDeporte)

        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();


            DataTable dt = new DataTable();
            this.intDeporte= intDeporte;
            string consulta = "select * from tblEquipo where intDeporte = @intDeporte";
            SqlCommand sql = new SqlCommand(consulta, conexion);
            sql.Parameters.AddWithValue("@intDeporte", this.intDeporte);
            sql.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(dt);
            return dt;
        }


        public DataTable consultarPartidos(string strNombreEquipo)

        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true ");
            conexion.Open();


            DataTable dt = new DataTable();
            this.strNombreEquipo = strNombreEquipo;
            string consulta = "select * from tblPartidos where strNombreEquipo = @strNombreEquipo";
            SqlCommand sql = new SqlCommand(consulta, conexion);
            sql.Parameters.AddWithValue("@strNombreEquipo", this.strNombreEquipo);
            sql.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(dt);
            return dt;
        }

        public bool insertarDatosApuesta(int intCedula)
        {
            try
                {
                    using (SqlConnection conexion = new SqlConnection("server=LAPTOP-IH6HOANE\\SQLEXPRESS;database=dboCasaApuesta; integrated security = true"))
                    {
                        conexion.Open();

                        // Inicia una transacción
                        using (SqlTransaction transaction = conexion.BeginTransaction())
                        {
                            // Verificar si los parámetros tienen valores válidos
                            if (intCedula <= 0 || intMontoApuesta <= 0)
                            {
                                Console.WriteLine("Los valores de cédula o monto de apuesta no son válidos.");
                                return false;
                            }

                            // 1. Verificar si hay suficiente monto disponible
                            string verificarMonto = "SELECT intMonto FROM tblRecargaRetiro WHERE intCedula = @intCedula";
                            using (SqlCommand verificarCommand = new SqlCommand(verificarMonto, conexion, transaction))
                            {
                                verificarCommand.Parameters.AddWithValue("@intCedula", intCedula);
                                object result = verificarCommand.ExecuteScalar();

                                // Asegurarse de que el resultado no sea nulo
                                if (result == null)
                                {
                                    Console.WriteLine("No se encontró un registro con la cédula especificada.");
                                    transaction.Rollback(); // Revertir cambios
                                    return false;
                                }

                                int montoDisponible = (int)result;

                                if (montoDisponible < intMontoApuesta)
                                {
                                    Console.WriteLine("No hay suficiente monto disponible para realizar la apuesta.");
                                    transaction.Rollback(); // Revertir cambios
                                    return false; // No se puede realizar la apuesta
                                }
                            }

                            // 2. Restar el monto de la apuesta
                            string restarMonto = "UPDATE tblRecargaRetiro SET intMonto = intMonto - @intMontoApuesta WHERE intCedula = @intCedula";
                            using (SqlCommand restarCommand = new SqlCommand(restarMonto, conexion, transaction))
                            {
                                restarCommand.Parameters.AddWithValue("@intCedula", intCedula);
                                restarCommand.Parameters.AddWithValue("@intMontoApuesta", intMontoApuesta);

                                int rowsAffected = restarCommand.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    Console.WriteLine("No se encontró un registro con la cédula especificada.");
                                    transaction.Rollback(); // Revertir cambios
                                    return false;
                                }
                            }

                            // 3. Insertar la apuesta
                            string insertarApuesta = "INSERT INTO tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta) VALUES (@intCedula, @strNombreEquipo, @strRival, @intValorAPagar, @intMontoApuesta)";
                            using (SqlCommand insertarCommand = new SqlCommand(insertarApuesta, conexion, transaction))
                            {
                                insertarCommand.Parameters.AddWithValue("@intCedula", intCedula);
                                insertarCommand.Parameters.AddWithValue("@strNombreEquipo", strNombreEquipo);
                                insertarCommand.Parameters.AddWithValue("@strRival", strRival);
                                insertarCommand.Parameters.AddWithValue("@intValorAPagar", intValorAPagar);
                                insertarCommand.Parameters.AddWithValue("@intMontoApuesta", intMontoApuesta);

                                insertarCommand.ExecuteNonQuery();
                            }

                            // Confirmar los cambios si todo sale bien
                            transaction.Commit();
                            Console.WriteLine("Apuesta registrada y monto actualizado exitosamente.");
                            return true;
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Manejo de errores SQL
                    Console.WriteLine($"Error en la base de datos: {sqlEx.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    // Manejo de errores generales
                    Console.WriteLine($"Se produjo un error: {ex.Message}");
                    return false;
                }

            }
        }


    }
