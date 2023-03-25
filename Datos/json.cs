using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Datos
{
    public static class json
    {
        public static string GEN_JSON(TreeView treeview)
        {
            // Se declara un MEMORYSTREAM para almacenar el JSON
            // en memoria
            using (var ms = new MemoryStream())
            {
                NodeRootDto nodeDto = new NodeRootDto();
                List<NODOHIJO> nP = new List<NODOHIJO>();
                // Se recorren los nodos en el TREEVIEW
                foreach (TreeNode padre in treeview.Nodes)
                {
                    var subChield = GetJson_ChieldNode(padre);
                    nP.Add(subChield);
                }
                // Se almacena la estructura
                nodeDto.Node = nP;
                // ' Se convierte e formato JSON
                string jsonstr = JsonConvert.SerializeObject(nodeDto);
                return jsonstr;
            }
        }
        private static NODOHIJO GetJson_ChieldNode(TreeNode node)
        {
            NODOHIJO chieldResult = new NODOHIJO()
            {
                Id = node.Name,
                Name = node.Text,
                Value = node.Checked,
                SubNodo = new List<NODOHIJO>()
            };
            if (node.Nodes != null && node.Nodes.Count > 0)
            {
                foreach (TreeNode ngObject in node.Nodes)
                {
                    var ch = GetJson_ChieldNode(ngObject);
                    chieldResult.SubNodo.Add(ch);
                }
            }
            return chieldResult;
        }
        // Carga de datos
        public static NodeRootDto LoadTree()
        {
            var result = new NodeRootDto()
            {
                Node = new List<NODOHIJO>()
            };
            var nodeArchivos = new NODOHIJO()
            {
                Id = "FileMenu",
                Name = "Archivo",
                Value = false
            };
            nodeArchivos.SubNodo = new List<NODOHIJO>();
            var subNodeNuevo = new NODOHIJO()
            {
                Id = "NewToolStripMenuItem",
                Name = "Nuevo",
                Value = false
            };
            // Sub subNodeNuevo ******************************************************
            subNodeNuevo.SubNodo = new List<NODOHIJO>();
            var SubNodoNuevo_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var SubNodoNuevo_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var SubNodoNuevo_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeNuevo.SubNodo.Add(SubNodoNuevo_New);
            subNodeNuevo.SubNodo.Add(SubNodoNuevo_Edit);
            subNodeNuevo.SubNodo.Add(SubNodoNuevo_Del);
            // END Sub subNodeNuevo ***************************************************
            var subNodeAbrir = new NODOHIJO()
            {
                Id = "OpenToolStripMenuItem",
                Name = "Abrir",
                Value = false
            };
            // Sub subNodeAbrir *********************************************************
            subNodeAbrir.SubNodo = new List<NODOHIJO>();
            var SubNodoAbrir_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var SubNodoAbrir_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var SubNodoAbrir_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeAbrir.SubNodo.Add(SubNodoAbrir_New);
            subNodeAbrir.SubNodo.Add(SubNodoAbrir_Edit);
            subNodeAbrir.SubNodo.Add(SubNodoAbrir_Del);
            // END Sub subNodeAbrir ****************************************************
            var subNodeGuardar = new NODOHIJO()
            {
                Id = "SaveToolStripMenuItem",
                Name = "Guardar",
                Value = false
            };
            // Sub subNodeGuardar ***************************************************
            subNodeGuardar.SubNodo = new List<NODOHIJO>();
            var SubNodoGuardar_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var SubNodoGuardar_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var SubNodoGuardar_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeGuardar.SubNodo.Add(SubNodoGuardar_New);
            subNodeGuardar.SubNodo.Add(SubNodoGuardar_Edit);
            subNodeGuardar.SubNodo.Add(SubNodoGuardar_Del);
            // END Sub subNodeGuardar ************************************************
            var subNodeGuardarComo = new NODOHIJO()
            {
                Id = "SaveAsToolStripMenuItem",
                Name = "Guardar Como",
                Value = false
            };
            // Sub subNodeGuardarCOMO ***********************************************
            subNodeGuardarComo.SubNodo = new List<NODOHIJO>();
            var SubNodoGuardarC_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var SubNodoGuardarC_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var SubNodoGuardarC_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeGuardarComo.SubNodo.Add(SubNodoGuardarC_New);
            subNodeGuardarComo.SubNodo.Add(SubNodoGuardarC_Edit);
            subNodeGuardarComo.SubNodo.Add(SubNodoGuardarC_Del);
            // END Sub subNodeGuardarCOMO *******************************************
            var subNodeImprimir = new NODOHIJO()
            {
                Id = "PrintToolStripMenuItem",
                Name = "Imprimir",
                Value = false
            };
            // Sub subNodeImprimir *****************************************
            subNodeImprimir.SubNodo = new List<NODOHIJO>();
            var SubNodoImprimir_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var SubNodoImprimir_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var SubNodoImprimir_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeImprimir.SubNodo.Add(SubNodoImprimir_New);
            subNodeImprimir.SubNodo.Add(SubNodoImprimir_Edit);
            subNodeImprimir.SubNodo.Add(SubNodoImprimir_Del);
            // END Sub subNodeImprimir ************************************************
            nodeArchivos.SubNodo.Add(subNodeNuevo);
            nodeArchivos.SubNodo.Add(subNodeAbrir);
            nodeArchivos.SubNodo.Add(subNodeGuardar);
            nodeArchivos.SubNodo.Add(subNodeGuardarComo);
            nodeArchivos.SubNodo.Add(subNodeImprimir);
            // END NODO 1 - MENU 1
            // ************************************************
            // NODO 2 ********************************************************
            var nodeEditar = new NODOHIJO()
            {
                Id = "EditMenu",
                Name = "Editar",
                Value = false
            };
            nodeEditar.SubNodo = new List<NODOHIJO>();
            var subNodeDeshacer = new NODOHIJO()
            {
                Id = "UndoToolStripMenuItem",
                Name = "Deshacer",
                Value = false
            };
            // Sub subNodeDeshacer ************************************************
            subNodeDeshacer.SubNodo = new List<NODOHIJO>();
            var subNodeDeshacer_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var subNodeDeshacer_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var subNodeDeshacer_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeDeshacer.SubNodo.Add(subNodeDeshacer_New);
            subNodeDeshacer.SubNodo.Add(subNodeDeshacer_Edit);
            subNodeDeshacer.SubNodo.Add(subNodeDeshacer_Del);
            // END Sub subNodeDeshacer ************************************************
            var subNodeRehacer = new NODOHIJO()
            {
                Id = "RedoToolStripMenuItem",
                Name = "Rehacer",
                Value = false
            };
            // Sub subNodeRehacer *****************************************
            subNodeRehacer.SubNodo = new List<NODOHIJO>();
            var subNodeRehacer_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var subNodeRehacer_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var subNodeRehacer_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeRehacer.SubNodo.Add(subNodeRehacer_New);
            subNodeRehacer.SubNodo.Add(subNodeRehacer_Edit);
            subNodeRehacer.SubNodo.Add(subNodeRehacer_Del);
            // END Sub subNodeRehacer ************************************************
            var subNodeCortar = new NODOHIJO()
            {
                Id = "CutToolStripMenuItem",
                Name = "Cortar",
                Value = false
            };
            // Sub subNodeCortar ******************************************
            subNodeCortar.SubNodo = new List<NODOHIJO>();
            var subNodeCortar_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var subNodeCortar_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var subNodeCortar_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeCortar.SubNodo.Add(subNodeCortar_New);
            subNodeCortar.SubNodo.Add(subNodeCortar_Edit);
            subNodeCortar.SubNodo.Add(subNodeCortar_Del);
            // END Sub subNodeCortar ****************************************************
            var subNodeCopiar = new NODOHIJO()
            {
                Id = "CopyToolStripMenuItem",
                Name = "Copiar",
                Value = false
            };
            // Sub subNodeCopiar ************************************************
            subNodeCopiar.SubNodo = new List<NODOHIJO>();
            var subNodeCopiar_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var subNodeCopiar_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var subNodeCopiar_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeCopiar.SubNodo.Add(subNodeCopiar_New);
            subNodeCopiar.SubNodo.Add(subNodeCopiar_Edit);
            subNodeCopiar.SubNodo.Add(subNodeCopiar_Del);
            // END Sub subNodeCopiar **************************************************
            var subNodePegar = new NODOHIJO()
            {
                Id = "PasteToolStripMenuItem",
                Name = "Pegar",
                Value = false
            };
            // Sub subNodePegar *********************************************
            subNodePegar.SubNodo = new List<NODOHIJO>();
            var subNodePegar_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var subNodePegar_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var subNodePegar_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodePegar.SubNodo.Add(subNodePegar_New);
            subNodePegar.SubNodo.Add(subNodePegar_Edit);
            subNodePegar.SubNodo.Add(subNodePegar_Del);
            // END Sub subNodePegar ***************************************************
            nodeEditar.SubNodo.Add(subNodeDeshacer);
            nodeEditar.SubNodo.Add(subNodeRehacer);
            nodeEditar.SubNodo.Add(subNodeCortar);
            nodeEditar.SubNodo.Add(subNodeCopiar);
            nodeEditar.SubNodo.Add(subNodePegar);
            // END NODO 2 - MENU 1
            // ************************************************
            // NODO 3 *****************************************************
            var nodeConfiguracion = new NODOHIJO()
            {
                Id = "ConfigMenu",
                Name = "Configuración",
                Value = false
            };
            nodeConfiguracion.SubNodo = new List<NODOHIJO>();
            var subUsuarios = new NODOHIJO()
            {
                Id = "UsuariosToolStripMenuItem",
                Name = "Usuarios",
                Value = false
            };
            // Sub subUsuarios **************************************************
            subUsuarios.SubNodo = new List<NODOHIJO>();
            var subUsuarios_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var subUsuarios_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var subUsuarios_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subUsuarios.SubNodo.Add(subUsuarios_New);
            subUsuarios.SubNodo.Add(subUsuarios_Edit);
            subUsuarios.SubNodo.Add(subUsuarios_Del);
            // END Sub subUsuarios ****************************************************
            var subNodeRoles = new NODOHIJO()
            {
                Id = "RolesToolStripMenuItem",
                Name = "Roles",
                Value = false
            };
            // Sub subNodeRoles ************************************************
            subNodeRoles.SubNodo = new List<NODOHIJO>();
            var subNodeRoles_New = new NODOHIJO()
            {
                Id = "ndoAnadir",
                Name = "Añadir",
                Value = false
            };
            var subNodeRoles_Edit = new NODOHIJO()
            {
                Id = "ndoEditar",
                Name = "Editar",
                Value = false
            };
            var subNodeRoles_Del = new NODOHIJO()
            {
                Id = "ndoElimi",
                Name = "Eliminar",
                Value = false
            };
            subNodeRoles.SubNodo.Add(subNodeRoles_New);
            subNodeRoles.SubNodo.Add(subNodeRoles_Edit);
            subNodeRoles.SubNodo.Add(subNodeRoles_Del);
            // END Sub subNodeRoles ***************************************************
            nodeConfiguracion.SubNodo.Add(subUsuarios);
            nodeConfiguracion.SubNodo.Add(subNodeRoles);
            // NODO 4 ********************************************************************************
             var nodeVentanas = new NODOHIJO()
             {
                 Id = "WindowsMenu",
                 Name = "Ventanas",
                 Value = false
             };
            nodeVentanas.SubNodo = new List<NODOHIJO>();
            var subNodeNueva = new NODOHIJO()
            {
                Id = "NewWindowToolStripMenuItem",
                Name = "Nueva Ventana",
                Value = false
            };
            var subNodeCascada = new NODOHIJO()
            {
                Id = "CascadeToolStripMenuItem",
                Name = "Cascada",
                Value = false
            };
            var subNodeMosaico = new NODOHIJO()
            {
                Id = "TileVerticalToolStripMenuItem",
                Name = "Mosaico Vertical",
                Value = false
            };
            var subNodeMosaico2 = new NODOHIJO()
            {
                Id = "TileHorizontalToolStripMenuItem",
                Name = "Mosaico Horizontal",
                Value = false
            };
            var subNodeCerrarTodo = new NODOHIJO()
            {
                Id = "CloseAllToolStripMenuItem",
                Name = "Cerrar Todo",
                Value = false
            };
            var subNodeOrganizar = new NODOHIJO()
            {
                Id = "ArrangeIconsToolStripMenuItem",
                Name = "Organizar Iconos",
                Value = false
            };
            nodeVentanas.SubNodo.Add(subNodeNueva);
            nodeVentanas.SubNodo.Add(subNodeCascada);
            nodeVentanas.SubNodo.Add(subNodeMosaico);
            nodeVentanas.SubNodo.Add(subNodeMosaico2);
            nodeVentanas.SubNodo.Add(subNodeCerrarTodo);
            nodeVentanas.SubNodo.Add(subNodeOrganizar);
            result.Node.Add(nodeArchivos);
            result.Node.Add(nodeEditar);
            result.Node.Add(nodeConfiguracion);
            result.Node.Add(nodeVentanas);
            return result;
        }
    }
}