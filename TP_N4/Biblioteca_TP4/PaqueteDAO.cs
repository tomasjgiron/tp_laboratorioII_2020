using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TP4
{
    public static class PaqueteDAO
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        static PaqueteDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection("Data Source = .; Database = correo-sp-2017; Trusted_Connection = True");
        }

        public static bool Insertar(Paquete p)
        {
            bool retorno = false;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Paquetes VALUES(@direccionEntrega," +
                    " @trackingID, @alumno)";

                comando.Parameters.Clear();
                comando.Parameters.Add(new SqlParameter("direccionEntrega", p.DireccionEntrega));
                comando.Parameters.Add(new SqlParameter("trackingID", p.TrackingID));
                comando.Parameters.Add(new SqlParameter("alumno", "Tomás Girón"));

                comando.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }
    }
}
