using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using Datos;
using Entidad;

namespace AplicacionCapas
{
    public partial class UsuarioRegistro : Form
    {
        public UsuarioRegistro()
        {
            InitializeComponent();
        }

        usuarios rol = new usuarios();
        public EntidadUsuario usu = new EntidadUsuario();


        public void Cargarcbox()
        {
            //rol.ListRol().Tables[0].Clear();
            cmbRol.DataSource = rol.ListRol().Tables[0];
            cmbRol.ValueMember = "id_Rol";
            cmbRol.DisplayMember = "nom_rol";
        }

        public void Limpiar()
        {
            txtNom.ResetText();
            txtApe.ResetText();
            txtLogin.ResetText();
            txtLogin.ReadOnly = true;
            txtPwd.ResetText();
            txtPwd2.ResetText();
            txtIdUsu.ResetText();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (usu.idusuario == null)
            {
                if (txtNom.Text != "" & txtApe.Text != "" & txtLogin.Text != "" & txtPwd.Text != "" &
               txtPwd2.Text != "")
                {
                    if (txtPwd.Text == txtPwd2.Text)
                    {
                        usuarios save = new usuarios();
                        string result;
                        result = save.AddUser(txtNom.Text, txtApe.Text, System.Convert.ToInt32(cmbRol.SelectedValue), txtLogin.Text, txtPwd.Text);
                        if (result == "1")
                        {
                            MessageBox.Show("Se Registro Con Exito", "", MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation);
                            Limpiar();
                            this.Close();
                        }
                        else if (result == "0")
                        {
                            MessageBox.Show("El usuario ya Existe", "", MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                            MessageBox.Show("ERROR: Se produjo un error en el Servidor de Datos Intentelo nuevamente" + Constants.vbNewLine + "Si persiste contactese con el Administrador del Sistema" + Constants.vbNewLine + save.erru, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Las contraseñas deben ser iguales", "", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Llenar todos los datos", "", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else if (txtNom.Text != "" & txtApe.Text != "" & txtLogin.Text != "")
            {
                if (txtPwd.Text == txtPwd2.Text)
                {
                    usuarios save = new usuarios();
                    string result;
                    result = save.UpUser(txtIdUsu.Text, txtNom.Text, txtApe.Text, System.Convert.ToInt32(cmbRol.SelectedValue), txtPwd.Text);
                    if (result == "1")
                    {
                        MessageBox.Show("Se ACTUALIZÓ Con Exito", "", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Limpiar();
                        this.Close();
                    }
                    else
                        MessageBox.Show("ERROR: Se produjo un error en el Servidor de Datos. Intentelo nuevamente" + Constants.vbNewLine + "Si persiste contactese con el Administrador del Sistema" + Constants.vbNewLine + save.erru, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Las contraseñas deben ser iguales", "", MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Llenar todos los datos", "", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
        }
        private void UsuarioRegistro_Load(object sender, EventArgs e)
        {

            Cargarcbox();
            if (usu.idusuario != null)
            {
                txtIdUsu.Text = usu.idusuario.ToString();
                txtNom.Text = usu.nombres.ToString();
                txtApe.Text = usu.apellidos.ToString();
                txtLogin.Text = usu.login.ToString();
                cmbRol.Text = usu.rol.ToString();

            }
        }
    }


}
