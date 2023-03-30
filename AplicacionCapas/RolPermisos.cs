using Datos;
using Entidad;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
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
    public partial class RolPermisos : Form
    {
        public RolPermisos()
        {
            InitializeComponent();
        }

        private void RolPermisos_Load(object sender, EventArgs e)
        {
            // Creamos una objeto ROL del tipo USUARIOS
            // para poder obtener el listado de los ROLES EN EL SISTEMA
            // y lo cargamos en un CONBOBOX
            usuarios rol = new usuarios();
            try
            {
                cmbRol.DataSource = rol.ListRol().Tables[0];
                cmbRol.ValueMember = "id_Rol";
                cmbRol.DisplayMember = "nom_Rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + rol.erru,
               "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostramos los PERMISOS cuando el valor del combobox
            // cambie o el usuario elija entre el listado
            if (cmbRol.SelectedIndex >= 0)
                // Cargar segun selección en bsae de datos
                VerPermisos(System.Convert.ToInt32(cmbRol.SelectedValue));
        }

        public void VerPermisos(int idrol)
        {
            tvPermisos.Nodes.Clear();
            usuarios ver = new usuarios();
            security sec = new security();
            string JSONStr = ver.VerPermisos(idrol).Tables[0].Rows[0][0].ToString();
            // ##############
            // AQUI APARECE EL PROBLEMA, OBTIENE EL JSON DE LA BD, PERO NO LO DESEREALIZA
            // AGREGUE NUEVOS NODOS, "ACTIONS"
            // TODO Siempre validar
            if (JSONStr != null & JSONStr != "")
            {
                var user = JsonConvert.DeserializeObject<NodeRootDto>(sec.DecryptText(JSONStr,
               "SECURITY_KEY"));
                populateTreeView(user.Node);
            }
            else
            {
                tvPermisos.Nodes.Clear();
                populateTreeView(json.LoadTree().Node);
            }
        }
        private void populateTreeView(List<NODOHIJO> childObjects)
        {
            if (childObjects != null && childObjects.Count > 0)
            {
                foreach (var ngObject in childObjects)
                {
                    string nodeText = ngObject.Name;
                    TreeNode childNode = new TreeNode(nodeText)
                    {
                        Checked = ngObject.Value,
                        Name = ngObject.Id
                    };
                    tvPermisos.Nodes.Add(childNode);
                    if ((ngObject.SubNodo != null && ngObject.SubNodo.Count > 0))
                        populateTreeView2(ngObject.SubNodo, childNode);
                }
            }
            tvPermisos.ExpandAll();
        }
        private void populateTreeView2(List<NODOHIJO> childObjects, TreeNode parentNode)
        {
            if (childObjects != null && childObjects.Count > 0)
            {
                foreach (var ngObject in childObjects)
                {
                    string nodeText = ngObject.Name;
                    TreeNode childNode = new TreeNode(nodeText)
                    {
                        Checked = ngObject.Value,
                        Name = ngObject.Id
                    };
                    parentNode.Nodes.Add(childNode);
                    if (ngObject.SubNodo != null && ngObject.SubNodo.Count > 0)
                        populateTreeView2(ngObject.SubNodo, childNode);
                }
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string NOM_Rol;
            usuarios adrol = new usuarios();
            NOM_Rol = Interaction.InputBox("Ingresa el NOMBRE del nuevo rol", "NUEVO ROL", "");
            if (NOM_Rol != "" & NOM_Rol != null)
            {
                if (adrol.AddRol(NOM_Rol) == 1)
                {
                    Interaction.MsgBox("Se inserto correctamente el nuevo ROL",
                   Constants.vbInformation);
                    RolPermisos_Load(sender, e);
                    cmbRol.Text = NOM_Rol;
                    tvPermisos.Nodes.Clear();
                    populateTreeView(json.LoadTree().Node);
                }
                else
                    MessageBox.Show(adrol.erru, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Manux
            // Se declaran variables para poder guardar el JSON generado
            // y se envia un mensaje de confirmacion o del posible error.
            security sec = new security();
            usuarios save = new usuarios();
            var result = save.UPRol(System.Convert.ToInt32(cmbRol.SelectedValue),
           sec.EncryptText(json.GEN_JSON(tvPermisos), "SECURITY_KEY"));
            if (result == "1")
                MessageBox.Show("Se guardo exitosamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("ERROR: " + save.erru, "", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }
    }
}
