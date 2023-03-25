namespace AplicacionCapas
{
    partial class UsuarioRegistro
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
            lblDatos = new Label();
            lblSeguridad = new Label();
            lblNombres = new Label();
            txtNom = new TextBox();
            lblContraseña = new Label();
            txtPwd = new TextBox();
            lblApellidos = new Label();
            txtApe = new TextBox();
            lblConfirmar = new Label();
            textBox4 = new TextBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            btnGuardar = new Button();
            txtRol = new TextBox();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Location = new Point(96, 34);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(42, 15);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "DATOS";
            // 
            // lblSeguridad
            // 
            lblSeguridad.AutoSize = true;
            lblSeguridad.Location = new Point(348, 34);
            lblSeguridad.Name = "lblSeguridad";
            lblSeguridad.Size = new Size(69, 15);
            lblSeguridad.TabIndex = 1;
            lblSeguridad.Text = "SEGURIDAD";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(19, 69);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(56, 15);
            lblNombres.TabIndex = 2;
            lblNombres.Text = "Nombres";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(96, 69);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(121, 23);
            txtNom.TabIndex = 3;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(263, 69);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(405, 66);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(131, 23);
            txtPwd.TabIndex = 5;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(19, 118);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 6;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApe
            // 
            txtApe.Location = new Point(96, 118);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(121, 23);
            txtApe.TabIndex = 7;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(263, 118);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(120, 15);
            lblConfirmar.TabIndex = 8;
            lblConfirmar.Text = "Confimar Contraseña";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(405, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 23);
            textBox4.TabIndex = 9;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(19, 169);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(96, 169);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(121, 23);
            txtLogin.TabIndex = 11;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(19, 211);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(96, 208);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(405, 169);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(263, 169);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(100, 23);
            txtRol.TabIndex = 16;
            // 
            // UsuarioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 285);
            Controls.Add(txtRol);
            Controls.Add(btnGuardar);
            Controls.Add(cmbRol);
            Controls.Add(lblRol);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(textBox4);
            Controls.Add(lblConfirmar);
            Controls.Add(txtApe);
            Controls.Add(lblApellidos);
            Controls.Add(txtPwd);
            Controls.Add(lblContraseña);
            Controls.Add(txtNom);
            Controls.Add(lblNombres);
            Controls.Add(lblSeguridad);
            Controls.Add(lblDatos);
            Name = "UsuarioRegistro";
            Text = "UsuarioRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Label lblSeguridad;
        private Label lblNombres;
        private TextBox txtNom;
        private Label lblContraseña;
        private TextBox txtPwd;
        private Label lblApellidos;
        private TextBox txtApe;
        private Label lblConfirmar;
        private TextBox textBox4;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblRol;
        private ComboBox cmbRol;
        private Button btnGuardar;
        private TextBox txtRol;
    }
}