using System.Data.SqlClient;

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
                var cs = @"Server=PC10\VE_SERVER;Database=BDPERMISOS;User Id=sesionlp;Password=lp2023;";
                cn = new SqlConnection(cs);
                if (cn.State == 0)
                    cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                er = ex.Message;
                return false;
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
