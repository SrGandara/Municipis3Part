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
            this.dadesBàsiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.territorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportistesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rRHHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zonesEmpleatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finestresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horitzontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organitzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.dadesBàsiquesToolStripMenuItem,
            this.comercialToolStripMenuItem,
            this.logísticaToolStripMenuItem,
            this.rRHHToolStripMenuItem,
            this.finestresToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MdiWindowListItem = this.finestresToolStripMenuItem;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1067, 28);
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
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.generalToolStripMenuItem.Text = "&General";
            // 
            // connexioBDToolStripMenuItem
            // 
            this.connexioBDToolStripMenuItem.Name = "connexioBDToolStripMenuItem";
            this.connexioBDToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.connexioBDToolStripMenuItem.Text = "&Connexió amb la base de dades";
            this.connexioBDToolStripMenuItem.Click += new System.EventHandler(this.connexioBDToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(301, 6);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.sortirToolStripMenuItem.Text = "&Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // dadesBàsiquesToolStripMenuItem
            // 
            this.dadesBàsiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regionsToolStripMenuItem,
            this.territorisToolStripMenuItem});
            this.dadesBàsiquesToolStripMenuItem.Enabled = false;
            this.dadesBàsiquesToolStripMenuItem.Name = "dadesBàsiquesToolStripMenuItem";
            this.dadesBàsiquesToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.dadesBàsiquesToolStripMenuItem.Text = "Dades &bàsiques";
            // 
            // regionsToolStripMenuItem
            // 
            this.regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            this.regionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.regionsToolStripMenuItem.Text = "&Regions";
            this.regionsToolStripMenuItem.Click += new System.EventHandler(this.regionsToolStripMenuItem_Click);
            // 
            // territorisToolStripMenuItem
            // 
            this.territorisToolStripMenuItem.Name = "territorisToolStripMenuItem";
            this.territorisToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.territorisToolStripMenuItem.Text = "&Territoris";
            this.territorisToolStripMenuItem.Click += new System.EventHandler(this.territorisToolStripMenuItem_Click);
            // 
            // comercialToolStripMenuItem
            // 
            this.comercialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.productesToolStripMenuItem,
            this.toolStripSeparator2,
            this.clientsToolStripMenuItem,
            this.comandesToolStripMenuItem});
            this.comercialToolStripMenuItem.Enabled = false;
            this.comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            this.comercialToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.comercialToolStripMenuItem.Text = "&Comercial";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.categoriesToolStripMenuItem.Text = "Ca&tegories de productes";
            // 
            // productesToolStripMenuItem
            // 
            this.productesToolStripMenuItem.Name = "productesToolStripMenuItem";
            this.productesToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.productesToolStripMenuItem.Text = "&Productes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.clientsToolStripMenuItem.Text = "Client&s";
            // 
            // comandesToolStripMenuItem
            // 
            this.comandesToolStripMenuItem.Name = "comandesToolStripMenuItem";
            this.comandesToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.comandesToolStripMenuItem.Text = "Co&mandes";
            // 
            // logísticaToolStripMenuItem
            // 
            this.logísticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transportistesToolStripMenuItem});
            this.logísticaToolStripMenuItem.Enabled = false;
            this.logísticaToolStripMenuItem.Name = "logísticaToolStripMenuItem";
            this.logísticaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.logísticaToolStripMenuItem.Text = "&Logística";
            // 
            // transportistesToolStripMenuItem
            // 
            this.transportistesToolStripMenuItem.Name = "transportistesToolStripMenuItem";
            this.transportistesToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.transportistesToolStripMenuItem.Text = "&Transportistes";
            // 
            // rRHHToolStripMenuItem
            // 
            this.rRHHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zonesEmpleatsToolStripMenuItem,
            this.empleatsToolStripMenuItem});
            this.rRHHToolStripMenuItem.Enabled = false;
            this.rRHHToolStripMenuItem.Name = "rRHHToolStripMenuItem";
            this.rRHHToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.rRHHToolStripMenuItem.Text = "&RR HH";
            // 
            // zonesEmpleatsToolStripMenuItem
            // 
            this.zonesEmpleatsToolStripMenuItem.Name = "zonesEmpleatsToolStripMenuItem";
            this.zonesEmpleatsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.zonesEmpleatsToolStripMenuItem.Text = "&Zones empleats";
            // 
            // empleatsToolStripMenuItem
            // 
            this.empleatsToolStripMenuItem.Name = "empleatsToolStripMenuItem";
            this.empleatsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.empleatsToolStripMenuItem.Text = "&Empleats";
            // 
            // finestresToolStripMenuItem
            // 
            this.finestresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horitzontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.cascadaToolStripMenuItem,
            this.organitzarToolStripMenuItem,
            this.toolStripSeparator3});
            this.finestresToolStripMenuItem.Name = "finestresToolStripMenuItem";
            this.finestresToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.finestresToolStripMenuItem.Text = "&Finestres";
            // 
            // horitzontalToolStripMenuItem
            // 
            this.horitzontalToolStripMenuItem.Name = "horitzontalToolStripMenuItem";
            this.horitzontalToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.horitzontalToolStripMenuItem.Text = "&Horitzontal";
            this.horitzontalToolStripMenuItem.Click += new System.EventHandler(this.horitzontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.verticalToolStripMenuItem.Text = "&Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.cascadaToolStripMenuItem.Text = "&Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // organitzarToolStripMenuItem
            // 
            this.organitzarToolStripMenuItem.Name = "organitzarToolStripMenuItem";
            this.organitzarToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.organitzarToolStripMenuItem.Text = "&Organitzar";
            this.organitzarToolStripMenuItem.Click += new System.EventHandler(this.organitzarToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
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
        private System.Windows.Forms.ToolStripMenuItem dadesBàsiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem territorisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportistesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rRHHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zonesEmpleatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finestresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horitzontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organitzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

