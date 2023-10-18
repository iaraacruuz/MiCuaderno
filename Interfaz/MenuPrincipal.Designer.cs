namespace Interfaz
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            cOMUNICACIONESToolStripMenuItem = new ToolStripMenuItem();
            nOTASToolStripMenuItem = new ToolStripMenuItem();
            cALENDARIOToolStripMenuItem = new ToolStripMenuItem();
            cERRARToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Green;
            menuStrip1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, cOMUNICACIONESToolStripMenuItem, nOTASToolStripMenuItem, cALENDARIOToolStripMenuItem, cERRARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(913, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(68, 27);
            iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // cOMUNICACIONESToolStripMenuItem
            // 
            cOMUNICACIONESToolStripMenuItem.Name = "cOMUNICACIONESToolStripMenuItem";
            cOMUNICACIONESToolStripMenuItem.Size = new Size(164, 27);
            cOMUNICACIONESToolStripMenuItem.Text = "COMUNICACIONES";
            cOMUNICACIONESToolStripMenuItem.Click += cOMUNICACIONESToolStripMenuItem_Click;
            // 
            // nOTASToolStripMenuItem
            // 
            nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            nOTASToolStripMenuItem.Size = new Size(76, 27);
            nOTASToolStripMenuItem.Text = "NOTAS";
            nOTASToolStripMenuItem.Click += nOTASToolStripMenuItem_Click;
            // 
            // cALENDARIOToolStripMenuItem
            // 
            cALENDARIOToolStripMenuItem.Name = "cALENDARIOToolStripMenuItem";
            cALENDARIOToolStripMenuItem.Size = new Size(124, 27);
            cALENDARIOToolStripMenuItem.Text = "CALENDARIO";
            cALENDARIOToolStripMenuItem.Click += cALENDARIOToolStripMenuItem_Click;
            // 
            // cERRARToolStripMenuItem
            // 
            cERRARToolStripMenuItem.Name = "cERRARToolStripMenuItem";
            cERRARToolStripMenuItem.Size = new Size(87, 27);
            cERRARToolStripMenuItem.Text = "CERRAR";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(913, 499);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem cOMUNICACIONESToolStripMenuItem;
        private ToolStripMenuItem nOTASToolStripMenuItem;
        private ToolStripMenuItem cALENDARIOToolStripMenuItem;
        private ToolStripMenuItem cERRARToolStripMenuItem;
    }
}