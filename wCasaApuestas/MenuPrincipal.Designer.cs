namespace WCasaApuestas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargasYRetirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenciónAlClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recargasYRetirosToolStripMenuItem,
            this.apuestasToolStripMenuItem,
            this.atenciónAlClienteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "&Menú";
            this.menúToolStripMenuItem.Click += new System.EventHandler(this.menúToolStripMenuItem_Click);
            // 
            // recargasYRetirosToolStripMenuItem
            // 
            this.recargasYRetirosToolStripMenuItem.Name = "recargasYRetirosToolStripMenuItem";
            this.recargasYRetirosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recargasYRetirosToolStripMenuItem.Text = "&Recargas y retiros";
            this.recargasYRetirosToolStripMenuItem.Click += new System.EventHandler(this.recargasYRetirosToolStripMenuItem_Click_1);
            // 
            // apuestasToolStripMenuItem
            // 
            this.apuestasToolStripMenuItem.Name = "apuestasToolStripMenuItem";
            this.apuestasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apuestasToolStripMenuItem.Text = "&Apuestas";
            this.apuestasToolStripMenuItem.Click += new System.EventHandler(this.apuestasToolStripMenuItem_Click_1);
            // 
            // atenciónAlClienteToolStripMenuItem
            // 
            this.atenciónAlClienteToolStripMenuItem.Name = "atenciónAlClienteToolStripMenuItem";
            this.atenciónAlClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atenciónAlClienteToolStripMenuItem.Text = "&Atención al cliente";
            this.atenciónAlClienteToolStripMenuItem.Click += new System.EventHandler(this.atenciónAlClienteToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargasYRetirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atenciónAlClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}