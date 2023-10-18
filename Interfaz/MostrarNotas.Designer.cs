namespace Interfaz
{
    partial class MostrarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarNotas));
            dataGridView2 = new DataGridView();
            Asignatura = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Asignatura, Valor });
            dataGridView2.Location = new Point(166, 72);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(408, 255);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Asignatura
            // 
            Asignatura.DataPropertyName = "Asignatura";
            Asignatura.HeaderText = "Asignatura";
            Asignatura.Name = "Asignatura";
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // MostrarNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 415);
            Controls.Add(dataGridView2);
            DoubleBuffered = true;
            HelpButton = true;
            Name = "MostrarNotas";
            Text = "MostrarNotas";
            Load += MostrarNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Asignatura;
        private DataGridViewTextBoxColumn Valor;
    }
}