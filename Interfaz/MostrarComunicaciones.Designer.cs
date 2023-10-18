namespace Interfaz
{
    partial class MostrarComunicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarComunicaciones));
            dataGridView2 = new DataGridView();
            Asunto = new DataGridViewTextBoxColumn();
            Mensaje = new DataGridViewTextBoxColumn();
            FechaEnvio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Asunto, Mensaje, FechaEnvio });
            dataGridView2.Location = new Point(224, 113);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(414, 232);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Asunto
            // 
            Asunto.DataPropertyName = "Asunto";
            Asunto.HeaderText = "Asunto";
            Asunto.Name = "Asunto";
            // 
            // Mensaje
            // 
            Mensaje.DataPropertyName = "Mensaje";
            Mensaje.HeaderText = "Mensaje";
            Mensaje.Name = "Mensaje";
            // 
            // FechaEnvio
            // 
            FechaEnvio.DataPropertyName = "FechaEnvio";
            FechaEnvio.HeaderText = "FechaEnvio";
            FechaEnvio.Name = "FechaEnvio";
            // 
            // MostrarComunicaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            DoubleBuffered = true;
            Name = "MostrarComunicaciones";
            Text = "MostrarComunicaciones";
            Load += MostrarComunicaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Asunto;
        private DataGridViewTextBoxColumn Mensaje;
        private DataGridViewTextBoxColumn FechaEnvio;
    }
}