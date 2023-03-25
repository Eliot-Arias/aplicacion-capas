using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CNN
    {
        public SqlConnection cn; 
        public string er;
        public bool INICIACONEX()
        {
            try
            {
                security SEC = new security(); 
                var cs = SEC.DecryptText(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString, "SECURITY_KEY");
                //cs = @"Server=DESKTOP-PE21LUS\MSSQLSERVER19;Database=BDPERMISOS;User Id=sesionlp;Password=lp2022;";
                cn = new SqlConnection(cs); 
                if (cn.State == 0) 
                    cn.Open(); 
                return true;
            }
            catch (Exception ex)
            {
                er = ex.Message; return false;
            }
        }

        public int CERRARCONEX()
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
