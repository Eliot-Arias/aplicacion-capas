namespace AplicacionCapas
{
    partial class ListarInformes
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
            lblOrden = new Label();
            txtordenId = new TextBox();
            btnInformeOrdenId = new Button();
            lblCodigoCliente = new Label();
            txtCodigoCliente = new TextBox();
            btnOrdenCliente = new Button();
            SuspendLayout();
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.Location = new Point(12, 25);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(54, 15);
            lblOrden.TabIndex = 0;
            lblOrden.Text = "Orden ID";
            // 
            // txtordenId
            // 
            txtordenId.Location = new Point(112, 22);
            txtordenId.Name = "txtordenId";
            txtordenId.Size = new Size(177, 23);
            txtordenId.TabIndex = 1;
            // 
            // btnInformeOrdenId
            // 
            btnInformeOrdenId.Location = new Point(325, 22);
            btnInformeOrdenId.Name = "btnInformeOrdenId";
            btnInformeOrdenId.Size = new Size(134, 23);
            btnInformeOrdenId.TabIndex = 2;
            btnInformeOrdenId.Text = "Informe Orden ID";
            btnInformeOrdenId.UseVisualStyleBackColor = true;
            btnInformeOrdenId.Click += btnInformeOrdenId_Click;
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(12, 85);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(86, 15);
            lblCodigoCliente.TabIndex = 3;
            lblCodigoCliente.Text = "Codigo Cliente";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(112, 82);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(177, 23);
            txtCodigoCliente.TabIndex = 4;
            // 
            // btnOrdenCliente
            // 
            btnOrdenCliente.Location = new Point(325, 81);
            btnOrdenCliente.Name = "btnOrdenCliente";
            btnOrdenCliente.Size = new Size(134, 23);
            btnOrdenCliente.TabIndex = 5;
            btnOrdenCliente.Text = "Informe Orden Cliente ";
            btnOrdenCliente.UseVisualStyleBackColor = true;
            btnOrdenCliente.Click += btnOrdenCliente_Click;
            // 
            // ListarInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 352);
            Controls.Add(btnOrdenCliente);
            Controls.Add(txtCodigoCliente);
            Controls.Add(lblCodigoCliente);
            Controls.Add(btnInformeOrdenId);
            Controls.Add(txtordenId);
            Controls.Add(lblOrden);
            Name = "ListarInformes";
            Text = "ListarInformes";
            Load += ListarInformes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrden;
        private TextBox txtordenId;
        private Button btnInformeOrdenId;
        private Label lblCodigoCliente;
        private TextBox txtCodigoCliente;
        private Button btnOrdenCliente;
    }
}