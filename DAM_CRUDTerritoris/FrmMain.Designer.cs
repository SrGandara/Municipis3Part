namespace DAM_CRUDTerritoris
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexioBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.municipisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comarquesPerHabitantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.municipisPerComarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.gestioToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1067, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexioBDToolStripMenuItem,
            this.toolStripSeparator1,
            this.sortirToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "&General";
            // 
            // connexioBDToolStripMenuItem
            // 
            this.connexioBDToolStripMenuItem.Name = "connexioBDToolStripMenuItem";
            this.connexioBDToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.connexioBDToolStripMenuItem.Text = "&Connexió amb la base de dades";
            this.connexioBDToolStripMenuItem.Click += new System.EventHandler(this.connexioBDToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.sortirToolStripMenuItem.Text = "&Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // gestioToolStripMenuItem
            // 
            this.gestioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarDadesToolStripMenuItem,
            this.municipisToolStripMenuItem,
            this.comarcasToolStripMenuItem});
            this.gestioToolStripMenuItem.Name = "gestioToolStripMenuItem";
            this.gestioToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.gestioToolStripMenuItem.Text = "Gestio";
            // 
            // importarDadesToolStripMenuItem
            // 
            this.importarDadesToolStripMenuItem.Name = "importarDadesToolStripMenuItem";
            this.importarDadesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.importarDadesToolStripMenuItem.Text = "Importar dades";
            this.importarDadesToolStripMenuItem.Click += new System.EventHandler(this.importarDadesToolStripMenuItem_Click);
            // 
            // municipisToolStripMenuItem
            // 
            this.municipisToolStripMenuItem.Name = "municipisToolStripMenuItem";
            this.municipisToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.municipisToolStripMenuItem.Text = "Municipis";
            this.municipisToolStripMenuItem.Click += new System.EventHandler(this.municipisToolStripMenuItem_Click);
            // 
            // comarcasToolStripMenuItem
            // 
            this.comarcasToolStripMenuItem.Name = "comarcasToolStripMenuItem";
            this.comarcasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.comarcasToolStripMenuItem.Text = "Comarcas";
            this.comarcasToolStripMenuItem.Click += new System.EventHandler(this.comarcasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comarquesPerHabitantsToolStripMenuItem,
            this.municipisPerComarcaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // comarquesPerHabitantsToolStripMenuItem
            // 
            this.comarquesPerHabitantsToolStripMenuItem.Name = "comarquesPerHabitantsToolStripMenuItem";
            this.comarquesPerHabitantsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.comarquesPerHabitantsToolStripMenuItem.Text = "Comarques per habitants";
            this.comarquesPerHabitantsToolStripMenuItem.Click += new System.EventHandler(this.comarquesPerHabitantsToolStripMenuItem_Click);
            // 
            // municipisPerComarcaToolStripMenuItem
            // 
            this.municipisPerComarcaToolStripMenuItem.Name = "municipisPerComarcaToolStripMenuItem";
            this.municipisPerComarcaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.municipisPerComarcaToolStripMenuItem.Text = "Municipis per Comarca";
            this.municipisPerComarcaToolStripMenuItem.Click += new System.EventHandler(this.municipisPerComarcaToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Exemple CRUD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexioBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarDadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem municipisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comarquesPerHabitantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem municipisPerComarcaToolStripMenuItem;
    }
}

