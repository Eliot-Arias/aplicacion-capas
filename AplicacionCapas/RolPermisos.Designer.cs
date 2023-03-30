namespace AplicacionCapas
{
    partial class RolPermisos
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
            lblRoles = new Label();
            cmbRol = new ComboBox();
            tvPermisos = new TreeView();
            btnNuevo = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Location = new Point(177, 20);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(81, 15);
            lblRoles.TabIndex = 0;
            lblRoles.Text = "Escoge un Rol";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(304, 17);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 1;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // tvPermisos
            // 
            tvPermisos.CheckBoxes = true;
            tvPermisos.Location = new Point(12, 55);
            tvPermisos.Name = "tvPermisos";
            tvPermisos.Size = new Size(413, 344);
            tvPermisos.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(89, 418);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(87, 37);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(272, 418);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(87, 37);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // RolPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 486);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(tvPermisos);
            Controls.Add(cmbRol);
            Controls.Add(lblRoles);
            Name = "RolPermisos";
            Text = "RolPermisos";
            Load += RolPermisos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoles;
        private ComboBox cmbRol;
        private TreeView tvPermisos;
        private Button btnNuevo;
        private Button btnGuardar;
    }
}