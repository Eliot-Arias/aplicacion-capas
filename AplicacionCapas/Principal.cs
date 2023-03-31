using Datos;
using Entidad;
using Newtonsoft.Json;
using System.Text;

namespace AplicacionCapas
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            ListaUsuario frm = new ListaUsuario();
            frm.ShowDialog();
        }

        private void menuRoles_Click(object sender, EventArgs e)
        {
            RolPermisos frm = new RolPermisos();
            frm.ShowDialog();
        }
        //asdasdsadsadsadsaddddddddddddddd
        private void LlenarMenu(List<NODOHIJO> childObjects)
        {
            if (childObjects != null && childObjects.Count > 0)
            {
                foreach (var ngObject in childObjects)
                {
                    foreach (ToolStripMenuItem oOpcionMenu in this.menuStrip.Items)
                    {
                        if (oOpcionMenu.Name.ToLower() == "mnuconfiguracion")
                        {
                            int A = 1;
                        }
                        if (oOpcionMenu.Name.ToLower() == ngObject.Id.ToLower())
                            oOpcionMenu.Enabled = ngObject.Value;
                        if ((ngObject.SubNodo != null && ngObject.SubNodo.Count > 0))
                            RecorrerSubMenu(ngObject.SubNodo,
                           oOpcionMenu.DropDownItems);
                    }
                }
            }
        }
        private void RecorrerSubMenu(List<NODOHIJO> childObjects, ToolStripItemCollection oSubmenuItems)
        {
            if (childObjects != null && childObjects.Count > 0)
            {
                foreach (var ngObject in childObjects)
                {
                    string nodeText = ngObject.Name;
                    foreach (ToolStripItem oSubItem in oSubmenuItems)
                    {
                        if (oSubItem.GetType() == typeof(ToolStripMenuItem))
                        {
                            if (oSubItem.Name.ToLower() == ngObject.Id.ToLower())
                            {
                                oSubItem.Enabled = ngObject.Value;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // ###############
            // Obtengo el JSON con los permisos de la base de datos de acuerdo al 
            // usuariolo Deserealizo y utilizo la funcion LlenarMenu y le envio 
            // el JSON utilizando el modelo creado
            security sec = new security();
            usuarios ver = new usuarios();

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding srcEncoding = Encoding.GetEncoding(1251);
            inicio.JSONStr = Convert.ToString(ver.VerDatosLogin(inicio.loginUsu).Tables[0].Rows[0][3]);
            // TODO Siempre validar
            inicio.JSONStr = sec.DecryptText(inicio.JSONStr, "SECURITY_KEY");
            var user = JsonConvert.DeserializeObject<NodeRootDto>(inicio.JSONStr);
            // MsgBox(user.Node(0).Id)
            LlenarMenu(user.Node);

            // #######################################################
            toolStripStatusLabel.Text = inicio.loginUsu;

        }
    }
}
