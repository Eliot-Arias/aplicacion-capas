using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;
using System.Data;

namespace Datos
{
    internal class DatosLogin
    {
        private static string strConexion = @"Server=DESKTOPPE21LUS\MSSQLSERVER19;Database=AplicacionCapas;UserId=sesionlp;Password=lp2023;";
        //private static string strConexion = @"Server=DESKTOPPE21LUS\MSSQLSERVER19;Database=AplicacionCapas;Trusted_Connection=True;";

        SqlConnection cn = new SqlConnection(strConexion);
        public DataTable Login (EntidadLogin e)
        {
            using (SqlCommand cmd = new SqlCommand("ValidaUsuario", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", e.Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", e.Contraseña);
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }
        
        
    }
}
