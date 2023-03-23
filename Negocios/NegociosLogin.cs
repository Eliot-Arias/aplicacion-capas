using System;
using System.Collections.Concurrent;
using System.Data;
using System.Text;
using System.Threading.Tasks;

//Dependencias
using Datos;
using Entidad;

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