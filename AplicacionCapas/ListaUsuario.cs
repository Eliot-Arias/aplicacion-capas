using Datos;
using Entidad;

namespace AplicacionCapas
{
    public partial class ListaUsuario : Form
    {
        public ListaUsuario()
        {
            InitializeComponent();
        }

        public void VerUsers()
        {
            usuarios CpaNog = new usuarios();
            dgList.DataSource = CpaNog.ListUsers().Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EntidadUsuario eUsuario = new EntidadUsuario();// entidad a pasa a formulario
            if (dgList.CurrentRow != null)
            {
                eUsuario.nombres = dgList.Rows[dgList.CurrentRow.Index].Cells["nomUser"].Value.ToString();
                eUsuario.apellidos = dgList.Rows[dgList.CurrentRow.Index].Cells["apeUser"].Value.ToString();
                eUsuario.idusuario = dgList.Rows[dgList.CurrentRow.Index].Cells["idUser"].Value.ToString();
                eUsuario.login = dgList.Rows[dgList.CurrentRow.Index].Cells["loginUser"].Value.ToString();
                eUsuario.rol = dgList.Rows[dgList.CurrentRow.Index].Cells["nomRol"].Value.ToString();
            }
            UsuarioRegistro frmRU = new UsuarioRegistro();
            frmRU.usu = eUsuario;// paso de entidad
            frmRU.ShowDialog();
            VerUsers();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UsuarioRegistro frmRU = new UsuarioRegistro();
            frmRU.usu = new EntidadUsuario();// paso de entidad
            frmRU.ShowDialog();
            VerUsers();
        }

        private void ListaUsuario_Load(object sender, EventArgs e)
        {
            VerUsers();
        }
    }
}
