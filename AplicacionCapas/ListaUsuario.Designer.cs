namespace AplicacionCapas
{
    partial class ListaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblClientes = new Label();
            btnEdit = new Button();
            btnAdd = new Button();
            dgList = new DataGridView();
            idUser = new DataGridViewTextBoxColumn();
            apeUser = new DataGridViewTextBoxColumn();
            nomUser = new DataGridViewTextBoxColumn();
            loginUser = new DataGridViewTextBoxColumn();
            fechCreaUsu = new DataGridViewTextBoxColumn();
            fechUp = new DataGridViewTextBoxColumn();
            nomRol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            SuspendLayout();
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(25, 21);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(105, 15);
            lblClientes.TabIndex = 0;
            lblClientes.Text = "LISTA DE CLIENTES";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(554, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Modificar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(664, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgList
            // 
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { idUser, apeUser, nomUser, loginUser, fechCreaUsu, fechUp, nomRol });
            dgList.Location = new Point(24, 50);
            dgList.Name = "dgList";
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(744, 260);
            dgList.TabIndex = 3;
            // 
            // idUser
            // 
            idUser.DataPropertyName = "id_user";
            idUser.HeaderText = "ID Usuario";
            idUser.Name = "idUser";
            // 
            // apeUser
            // 
            apeUser.DataPropertyName = "ape_user";
            apeUser.HeaderText = "Apellidos";
            apeUser.Name = "apeUser";
            // 
            // nomUser
            // 
            nomUser.DataPropertyName = "nom_user";
            nomUser.HeaderText = "Nombres";
            nomUser.Name = "nomUser";
            // 
            // loginUser
            // 
            loginUser.DataPropertyName = "login_user";
            loginUser.HeaderText = "Login";
            loginUser.Name = "loginUser";
            // 
            // fechCreaUsu
            // 
            fechCreaUsu.DataPropertyName = "fech_user";
            fechCreaUsu.HeaderText = "Fecha Creación";
            fechCreaUsu.Name = "fechCreaUsu";
            // 
            // fechUp
            // 
            fechUp.DataPropertyName = "fech_up";
            fechUp.HeaderText = "Fecha Actualización";
            fechUp.Name = "fechUp";
            // 
            // nomRol
            // 
            nomRol.DataPropertyName = "Nom_Rol";
            nomRol.HeaderText = "Rol Usuario";
            nomRol.Name = "nomRol";
            // 
            // ListaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 405);
            Controls.Add(dgList);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(lblClientes);
            Name = "ListaUsuario";
            Text = "ListaUsuario";
            Load += ListaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClientes;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgList;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn apeUser;
        private DataGridViewTextBoxColumn nomUser;
        private DataGridViewTextBoxColumn loginUser;
        private DataGridViewTextBoxColumn fechCreaUsu;
        private DataGridViewTextBoxColumn fechUp;
        private DataGridViewTextBoxColumn nomRol;
    }
}