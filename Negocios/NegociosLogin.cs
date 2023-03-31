//Dependencias
using Datos;
using Entidad;
using System.Data;

namespace Negocios
{
    public class NegociosLogin
    {
        DatosLogin objDatos = new DatosLogin();
        public DataTable LogonN(EntidadLogin e)
        {
            return objDatos.Login(e);
        }


    }
}