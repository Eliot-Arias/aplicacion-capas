namespace AplicacionCapas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnlHeader = new Panel();
            btnClose = new Button();
            lblIngreso = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            pnlFooter = new Panel();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(83, 127, 221);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lblIngreso);
            pnlHeader.Location = new Point(0, -1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(503, 56);
            pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            btnClose.FlatAppearance.BorderSize = 5;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 0, 0);
            btnClose.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(449, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 35);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreso.Location = new Point(203, 10);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(104, 35);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Ingreso";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(252, 61);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(102, 29);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(252, 103);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(229, 23);
            txtUsuario.TabIndex = 3;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.Location = new Point(252, 152);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(144, 29);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(252, 184);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(229, 23);
            txtContraseña.TabIndex = 5;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(93, 109, 126);
            pnlFooter.Location = new Point(0, 315);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(503, 35);
            pnlFooter.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(252, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(229, 46);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 245);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 205, 230);
            ClientSize = new Size(503, 350);
            Controls.Add(btnLogin);
            Controls.Add(pnlFooter);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Button btnClose;
        private Label lblIngreso;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Panel pnlFooter;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}