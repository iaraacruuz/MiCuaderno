namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Info;
            txtUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.InactiveCaptionText;
            txtUsuario.Location = new Point(259, 146);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese Usuario";
            txtUsuario.Size = new Size(238, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtClave
            // 
            txtClave.BackColor = SystemColors.Info;
            txtClave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtClave.ForeColor = SystemColors.InactiveCaptionText;
            txtClave.Location = new Point(259, 198);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "Ingrese la Contraseña";
            txtClave.Size = new Size(238, 23);
            txtClave.TabIndex = 2;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.Info;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ActiveCaptionText;
            btnIngresar.Location = new Point(285, 245);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(182, 34);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LightGreen;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.OrangeRed;
            btnCerrar.Location = new Point(683, 376);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 62);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCerrar);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "LOGIN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIngresar;
        private Button btnCerrar;
    }
}