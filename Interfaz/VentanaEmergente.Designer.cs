namespace Interfaz
{
    partial class VentanaEmergente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEmergente));
            btnOK = new Button();
            lblTitulo = new Label();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.SandyBrown;
            btnOK.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.Location = new Point(147, 149);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(115, 41);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.MenuHighlight;
            lblTitulo.Location = new Point(180, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(66, 29);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = SystemColors.MenuHighlight;
            lblMensaje.Location = new Point(42, 101);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(47, 29);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "msj";
            lblMensaje.Click += lblMensaje_Click;
            // 
            // VentanaEmergente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(431, 276);
            ControlBox = false;
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaEmergente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += VentanaEmergente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Label lblTitulo;
        private Label lblMensaje;
    }
}