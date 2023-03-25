using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class usuarios
    {
        public string erru;
        private security md5 = new security();
        // funciones para listar y manipular datos de usuarios
        // functions to list and manipulate user data
        public string Login(string usu, string pass)
        {
            string strLogin;
            try
            {
                CNN dllBD = new CNN();
                dllBD.INICIACONEX();
                SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_LOGIN", dllBD.cn);
                dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dpt.SelectCommand.Parameters.AddWithValue("@LOGIN", usu);
                dpt.SelectCommand.Parameters.AddWithValue("@PASS", md5.getMd5Hash(pass));
                dpt.SelectCommand.Parameters.AddWithValue("@RESULT", " ");
                dpt.SelectCommand.Parameters["@RESULT"].Direction = ParameterDirection.Output;
                dpt.SelectCommand.ExecuteNonQuery();
                strLogin = Strings.Trim(dpt.SelectCommand.Parameters["@RESULT"].Value.ToString());
                dllBD.CERRARCONEX();
                dpt = null;
                dllBD = null/* TODO Change to default(_) if this is not a reference type */;
            }
            catch (Exception ex)
            {
                strLogin = "2";
                erru = ex.Message;
            }
            return strLogin;
        }
        public string AddUser(string Nom, string Ape, int TUsu, string Login, string Pass)
        {
            string strAddUser;
            try
            {
                DataSet ds = new DataSet();
                CNN dllBD = new CNN();
                dllBD.INICIACONEX();
                SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_INSERT", dllBD.cn);
                dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dpt.SelectCommand.Parameters.AddWithValue("@NOM", Nom);
                dpt.SelectCommand.Parameters.AddWithValue("@LOG", Login);
                dpt.SelectCommand.Parameters.AddWithValue("@IDROL", TUsu);
                dpt.SelectCommand.Parameters.AddWithValue("@PASS", md5.getMd5Hash(Pass));
                dpt.SelectCommand.Parameters.AddWithValue("@APE", Ape);
                dpt.SelectCommand.Parameters.AddWithValue("@RESULT", " ");
                dpt.SelectCommand.Parameters["@RESULT"].Direction = ParameterDirection.Output;
                dpt.SelectCommand.ExecuteNonQuery();
                strAddUser = Strings.Trim(dpt.SelectCommand.Parameters["@RESULT"].Value.ToString());
                dllBD.CERRARCONEX();
                dllBD = null/* TODO Change to default(_) if this is not a reference type */;
                dpt = null;
            }
            catch (Exception ex)
            {
                erru = ex.Message;
                strAddUser = "3";
            }
            return strAddUser;
        }
        public string UpUser(string idUsu, string Nom, string Ape, int TUsu, string Pass = null)
        {
            string strUpUser;
            try
            {
                DataSet ds = new DataSet();
                CNN dllBD = new CNN();
                string password = "";
                dllBD.INICIACONEX();
                SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_UPDATE", dllBD.cn);
                dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dpt.SelectCommand.Parameters.AddWithValue("@IDUSU", idUsu);
                dpt.SelectCommand.Parameters.AddWithValue("@NOM", Nom);
                dpt.SelectCommand.Parameters.AddWithValue("@APE", Ape);
                if (Pass != "")
                    password = md5.getMd5Hash(Pass);
                dpt.SelectCommand.Parameters.AddWithValue("@PASS", password);
                dpt.SelectCommand.Parameters.AddWithValue("@TIPOUSU", TUsu);
                dpt.SelectCommand.Parameters.AddWithValue("@RESULT", " ");
                dpt.SelectCommand.Parameters["@RESULT"].Direction = ParameterDirection.Output;
                dpt.SelectCommand.ExecuteNonQuery();
                strUpUser = Strings.Trim(dpt.SelectCommand.Parameters["@RESULT"].Value.ToString());
                dllBD.CERRARCONEX();
                dllBD = null/* TODO Change to default(_) if this is not a reference type */;
                dpt = null;
                ds = null/* TODO Change to default(_) if this is not a reference type */;
                password = null;
            }
            catch (Exception ex)
            {
                erru = "Error en Clase: " + ex.Message;
                strUpUser = "3";
            }
            return strUpUser;
        }
        public DataSet ListUsers()
        {
            DataSet ds = new DataSet();
            CNN dllBD = new CNN();
            dllBD.INICIACONEX();
            SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_LIST", dllBD.cn);
            dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dpt.Fill(ds, "SP_USU_LIST");
            dllBD.CERRARCONEX();
            return ds;
            ////dllBD = null/* TODO Change to default(_) if this is not a reference type */;
            ////ds = null/* TODO Change to default(_) if this is not a reference type */;
            ////dpt = null;
        }
        public bool DelUsu(string DB, string usu)
        {
            try
            {
                CNN dllBD = new CNN();
                if (dllBD.INICIACONEX() == true)
                {
                    SqlDataAdapter dpt = new SqlDataAdapter("UST_DELETE_USU", dllBD.cn);
                    dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dpt.SelectCommand.Parameters.AddWithValue("@IDUSU", usu);
                    dpt.SelectCommand.ExecuteNonQuery();
                    dllBD.CERRARCONEX();
                    dpt = null;
                    dllBD = null/* TODO Change to default(_) if this is not a reference type */;
                    return true;
                }
                else
                {
                    erru = dllBD.er;
                    return false;
                }
            }
            catch (Exception ex)
            {
                erru = ex.Message;
                return false;
            }
        }
        public DataSet ListRol()
        {
            DataSet ds = new DataSet();
            CNN dllBD = new CNN();
            dllBD.INICIACONEX();
            SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_LISTROL", dllBD.cn);
            dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dpt.Fill(ds, "SP_USU_LISTROL");
            dllBD.CERRARCONEX();
            return ds;
            //// dllBD = null/* TODO Change to default(_) if this is not a reference type */;
            //// ds = null/* TODO Change to default(_) if this is not a reference type */;
            //// dpt = null;
            ////
        }
        public DataSet VerPermisos(int idRol)
        {
            try
            {
                DataSet ds = new DataSet();
                CNN dllBD = new CNN();
                dllBD.INICIACONEX();
                SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_VERPERM", dllBD.cn);
                dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dpt.SelectCommand.Parameters.AddWithValue("@IDROL", idRol);
                dpt.Fill(ds, "SP_USU_VERPERM");
                return ds;
                ////dllBD.CERRARCONEX();
                ////dpt = null;
                ////dllBD = null/* TODO Change to default(_) if this is not a reference type */;
            }
            catch (Exception ex)
            {
                erru = ex.Message;
                return new DataSet();
            }
        }
        public string UPRol(int idRol, string permisos)
        {
            string strUPRol;
            try
            {
                CNN dllBD = new CNN();
                dllBD.INICIACONEX();
                SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_UPPERMISO", dllBD.cn);
                dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dpt.SelectCommand.Parameters.AddWithValue("@IDROL", idRol);
                dpt.SelectCommand.Parameters.AddWithValue("@PERMISOS", permisos);
                dpt.SelectCommand.Parameters.AddWithValue("@RESULT", " ");
                dpt.SelectCommand.Parameters["@RESULT"].Direction = ParameterDirection.Output;
                dpt.SelectCommand.ExecuteNonQuery();
                strUPRol = Strings.Trim(dpt.SelectCommand.Parameters["@RESULT"].Value.ToString());
                dllBD.CERRARCONEX();
                //dllBD = null/* TODO Change to default(_) if this is not a reference type */;
                //dpt = null;
            }
            catch (Exception ex)
            {
                erru = "Error en Clase: " + ex.Message;
                strUPRol = "3";
            }
            return strUPRol;
        }
        public DataSet VerDatosLogin(string loginUsu)
        {
            try
            {
                DataSet ds = new DataSet();
                CNN dllBD = new CNN();
                dllBD.INICIACONEX();
                SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_VER", dllBD.cn);
                dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dpt.SelectCommand.Parameters.AddWithValue("@LOGIN", loginUsu);
                dpt.Fill(ds, "SP_USU_VER");
                dllBD.CERRARCONEX();
                return ds;
                ////dpt = null;
                ////dllBD = null/* TODO Change to default(_) if this is not a reference type */;
            }
            catch (Exception ex)
            {
                erru = ex.Message;
                return new DataSet();
            }
        }
        public int AddRol(string nomRol)
        {
            try
            {
                DataSet ds = new DataSet();
                CNN dllBD = new CNN();
                dllBD.INICIACONEX();
                SqlDataAdapter dpt = new SqlDataAdapter("SP_USU_INSERT_ROL", dllBD.cn);
                dpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dpt.SelectCommand.Parameters.AddWithValue("@NOMROL", nomRol);
                dpt.SelectCommand.Parameters.AddWithValue("@RESULT", " ");
                dpt.SelectCommand.Parameters["@RESULT"].Direction = ParameterDirection.Output;
                dpt.SelectCommand.ExecuteNonQuery();
                dllBD.CERRARCONEX();
                return Convert.ToInt32(Strings.Trim(dpt.SelectCommand.Parameters["@RESULT"].Value.ToString()));
            }
            catch (Exception ex)
            {
                erru = ex.Message;
                return 2;
            }
        }
    }
}
