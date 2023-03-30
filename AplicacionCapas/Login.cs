using Datos;
using Entidad;
using Microsoft.VisualBasic;
using Negocios;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCapas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        EntidadLogin objEntidad = new EntidadLogin();
        NegociosLogin objNegocios = new NegociosLogin();

        void ValidaLogin()
        {
            objEntidad.Usuario = txtUsuario.Text;
            objEntidad.Contraseña = txtContraseña.Text;

            DataTable tbl = objNegocios.LogonN(objEntidad);
            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("No Cohinsiden Usuario O Contraseña \n Intentelo Nuevamente",
                    "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Bienvenido al Sistema", "Acceso al Sistema", MessageBoxButtons.OK);
                //FrmMenuPrincipal Frm = new FrmMenuPrincipal();
                //Frm.Show();
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ValidaLogin();
            if (txtUsuario.Text == "")
                txtUsuario.Focus();
            else if (txtContraseña.Text == "")
                txtContraseña.Focus();
            else
            {
                string add;
                usuarios LOG = new usuarios();
                add = LOG.Login(txtUsuario.Text, txtContraseña.Text);
                if (add == "1")
                {
                    inicio.loginUsu = txtUsuario.Text;
                    Principal frm = new Principal();
                    frm.Show();
                    this.Hide();
                }
                else if (add == "0")
                {
                    MessageBox.Show("ERROR de USUARIO y CONTRASEÑA" + Constants.vbNewLine + "Vuelva a Intentarlo",
                   "Inicio de Sesión ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.ResetText();
                    txtContraseña.Focus();
                }
                else
                    MessageBox.Show("ERROR de SERVIDOR, revice su conexion y el SERVIDOR." + Constants.vbNewLine +
                   "Vuelva a Intentarlo" + Constants.vbNewLine + LOG.erru, "Inicio de Sesión ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
