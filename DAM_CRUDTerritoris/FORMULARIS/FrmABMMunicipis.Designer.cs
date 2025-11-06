namespace DAM_CRUDTerritoris.FORMULARIS {
    partial class FrmABMMunicipis {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCodiIne = new System.Windows.Forms.TextBox();
            this.lbCodiINE = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.cbCodiComarcas = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.lbWeb = new System.Windows.Forms.Label();
            this.lbCentreLatitud = new System.Windows.Forms.Label();
            this.lbCentreLongitud = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbBandera = new System.Windows.Forms.Label();
            this.lbEscut = new System.Windows.Forms.Label();
            this.lbCodiComarca = new System.Windows.Forms.Label();
            this.lbHabitants = new System.Windows.Forms.Label();
            this.nudHabitants = new System.Windows.Forms.NumericUpDown();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.tbBandera = new System.Windows.Forms.TextBox();
            this.tbEscut = new System.Windows.Forms.TextBox();
            this.tbWeb = new System.Windows.Forms.TextBox();
            this.tbCentreLat = new System.Windows.Forms.TextBox();
            this.tbCentreLong = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHabitants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(28, 21);
            this.lbId.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(3);
            this.lbId.Size = new System.Drawing.Size(118, 22);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id.";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(150, 21);
            this.tbId.MaxLength = 20;
            this.tbId.Name = "tbId";
            this.tbId.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbId.Size = new System.Drawing.Size(412, 23);
            this.tbId.TabIndex = 1;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCodiIne
            // 
            this.tbCodiIne.Location = new System.Drawing.Point(150, 50);
            this.tbCodiIne.MaxLength = 50;
            this.tbCodiIne.Name = "tbCodiIne";
            this.tbCodiIne.Size = new System.Drawing.Size(412, 23);
            this.tbCodiIne.TabIndex = 3;
            // 
            // lbCodiINE
            // 
            this.lbCodiINE.AutoSize = true;
            this.lbCodiINE.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbCodiINE.ForeColor = System.Drawing.Color.White;
            this.lbCodiINE.Location = new System.Drawing.Point(28, 50);
            this.lbCodiINE.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbCodiINE.Name = "lbCodiINE";
            this.lbCodiINE.Padding = new System.Windows.Forms.Padding(3);
            this.lbCodiINE.Size = new System.Drawing.Size(118, 22);
            this.lbCodiINE.TabIndex = 2;
            this.lbCodiINE.Text = "Codi INE";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(28, 81);
            this.lbNom.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(3);
            this.lbNom.Size = new System.Drawing.Size(118, 22);
            this.lbNom.TabIndex = 4;
            this.lbNom.Text = "Nom";
            // 
            // cbCodiComarcas
            // 
            this.cbCodiComarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodiComarcas.FormattingEnabled = true;
            this.cbCodiComarcas.Location = new System.Drawing.Point(150, 325);
            this.cbCodiComarcas.Name = "cbCodiComarcas";
            this.cbCodiComarcas.Size = new System.Drawing.Size(412, 24);
            this.cbCodiComarcas.TabIndex = 5;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(179, 354);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(114, 47);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(342, 354);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(114, 47);
            this.btNo.TabIndex = 7;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // lbWeb
            // 
            this.lbWeb.AutoSize = true;
            this.lbWeb.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbWeb.ForeColor = System.Drawing.Color.White;
            this.lbWeb.Location = new System.Drawing.Point(28, 172);
            this.lbWeb.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbWeb.Name = "lbWeb";
            this.lbWeb.Padding = new System.Windows.Forms.Padding(3);
            this.lbWeb.Size = new System.Drawing.Size(118, 22);
            this.lbWeb.TabIndex = 10;
            this.lbWeb.Text = "Web";
            // 
            // lbCentreLatitud
            // 
            this.lbCentreLatitud.AutoSize = true;
            this.lbCentreLatitud.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbCentreLatitud.ForeColor = System.Drawing.Color.White;
            this.lbCentreLatitud.Location = new System.Drawing.Point(28, 141);
            this.lbCentreLatitud.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbCentreLatitud.Name = "lbCentreLatitud";
            this.lbCentreLatitud.Padding = new System.Windows.Forms.Padding(3);
            this.lbCentreLatitud.Size = new System.Drawing.Size(118, 22);
            this.lbCentreLatitud.TabIndex = 9;
            this.lbCentreLatitud.Text = "Centre Latitud";
            // 
            // lbCentreLongitud
            // 
            this.lbCentreLongitud.AutoSize = true;
            this.lbCentreLongitud.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbCentreLongitud.ForeColor = System.Drawing.Color.White;
            this.lbCentreLongitud.Location = new System.Drawing.Point(28, 112);
            this.lbCentreLongitud.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbCentreLongitud.Name = "lbCentreLongitud";
            this.lbCentreLongitud.Padding = new System.Windows.Forms.Padding(3);
            this.lbCentreLongitud.Size = new System.Drawing.Size(118, 22);
            this.lbCentreLongitud.TabIndex = 8;
            this.lbCentreLongitud.Text = "Centre Longitud";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbAltura.ForeColor = System.Drawing.Color.White;
            this.lbAltura.Location = new System.Drawing.Point(28, 263);
            this.lbAltura.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Padding = new System.Windows.Forms.Padding(3);
            this.lbAltura.Size = new System.Drawing.Size(118, 22);
            this.lbAltura.TabIndex = 13;
            this.lbAltura.Text = "Altura";
            // 
            // lbBandera
            // 
            this.lbBandera.AutoSize = true;
            this.lbBandera.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbBandera.ForeColor = System.Drawing.Color.White;
            this.lbBandera.Location = new System.Drawing.Point(28, 232);
            this.lbBandera.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbBandera.Name = "lbBandera";
            this.lbBandera.Padding = new System.Windows.Forms.Padding(3);
            this.lbBandera.Size = new System.Drawing.Size(118, 22);
            this.lbBandera.TabIndex = 12;
            this.lbBandera.Text = "Bandera";
            // 
            // lbEscut
            // 
            this.lbEscut.AutoSize = true;
            this.lbEscut.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbEscut.ForeColor = System.Drawing.Color.White;
            this.lbEscut.Location = new System.Drawing.Point(28, 203);
            this.lbEscut.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbEscut.Name = "lbEscut";
            this.lbEscut.Padding = new System.Windows.Forms.Padding(3);
            this.lbEscut.Size = new System.Drawing.Size(118, 22);
            this.lbEscut.TabIndex = 11;
            this.lbEscut.Text = "Escut";
            // 
            // lbCodiComarca
            // 
            this.lbCodiComarca.AutoSize = true;
            this.lbCodiComarca.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbCodiComarca.ForeColor = System.Drawing.Color.White;
            this.lbCodiComarca.Location = new System.Drawing.Point(28, 325);
            this.lbCodiComarca.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbCodiComarca.Name = "lbCodiComarca";
            this.lbCodiComarca.Padding = new System.Windows.Forms.Padding(3);
            this.lbCodiComarca.Size = new System.Drawing.Size(118, 22);
            this.lbCodiComarca.TabIndex = 15;
            this.lbCodiComarca.Text = "Codi Comarca";
            // 
            // lbHabitants
            // 
            this.lbHabitants.AutoSize = true;
            this.lbHabitants.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbHabitants.ForeColor = System.Drawing.Color.White;
            this.lbHabitants.Location = new System.Drawing.Point(28, 294);
            this.lbHabitants.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbHabitants.Name = "lbHabitants";
            this.lbHabitants.Padding = new System.Windows.Forms.Padding(3);
            this.lbHabitants.Size = new System.Drawing.Size(118, 22);
            this.lbHabitants.TabIndex = 14;
            this.lbHabitants.Text = "Habitants";
            // 
            // nudHabitants
            // 
            this.nudHabitants.Location = new System.Drawing.Point(149, 292);
            this.nudHabitants.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudHabitants.Name = "nudHabitants";
            this.nudHabitants.Size = new System.Drawing.Size(410, 23);
            this.nudHabitants.TabIndex = 16;
            // 
            // nudAltura
            // 
            this.nudAltura.Location = new System.Drawing.Point(150, 262);
            this.nudAltura.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(409, 23);
            this.nudAltura.TabIndex = 17;
            // 
            // tbBandera
            // 
            this.tbBandera.Location = new System.Drawing.Point(150, 232);
            this.tbBandera.MaxLength = 20;
            this.tbBandera.Name = "tbBandera";
            this.tbBandera.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbBandera.Size = new System.Drawing.Size(412, 23);
            this.tbBandera.TabIndex = 18;
            this.tbBandera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEscut
            // 
            this.tbEscut.Location = new System.Drawing.Point(150, 203);
            this.tbEscut.MaxLength = 20;
            this.tbEscut.Name = "tbEscut";
            this.tbEscut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbEscut.Size = new System.Drawing.Size(412, 23);
            this.tbEscut.TabIndex = 19;
            this.tbEscut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWeb
            // 
            this.tbWeb.Location = new System.Drawing.Point(150, 172);
            this.tbWeb.MaxLength = 20;
            this.tbWeb.Name = "tbWeb";
            this.tbWeb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbWeb.Size = new System.Drawing.Size(412, 23);
            this.tbWeb.TabIndex = 20;
            this.tbWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCentreLat
            // 
            this.tbCentreLat.Location = new System.Drawing.Point(150, 141);
            this.tbCentreLat.MaxLength = 20;
            this.tbCentreLat.Name = "tbCentreLat";
            this.tbCentreLat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCentreLat.Size = new System.Drawing.Size(412, 23);
            this.tbCentreLat.TabIndex = 21;
            this.tbCentreLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCentreLong
            // 
            this.tbCentreLong.Location = new System.Drawing.Point(150, 112);
            this.tbCentreLong.MaxLength = 20;
            this.tbCentreLong.Name = "tbCentreLong";
            this.tbCentreLong.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCentreLong.Size = new System.Drawing.Size(412, 23);
            this.tbCentreLong.TabIndex = 22;
            this.tbCentreLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(150, 83);
            this.tbNom.MaxLength = 20;
            this.tbNom.Name = "tbNom";
            this.tbNom.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNom.Size = new System.Drawing.Size(412, 23);
            this.tbNom.TabIndex = 23;
            this.tbNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmABMMunicipis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(580, 413);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbCentreLong);
            this.Controls.Add(this.tbCentreLat);
            this.Controls.Add(this.tbWeb);
            this.Controls.Add(this.tbEscut);
            this.Controls.Add(this.tbBandera);
            this.Controls.Add(this.nudAltura);
            this.Controls.Add(this.nudHabitants);
            this.Controls.Add(this.lbCodiComarca);
            this.Controls.Add(this.lbHabitants);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbBandera);
            this.Controls.Add(this.lbEscut);
            this.Controls.Add(this.lbWeb);
            this.Controls.Add(this.lbCentreLatitud);
            this.Controls.Add(this.lbCentreLongitud);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbCodiComarcas);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbCodiIne);
            this.Controls.Add(this.lbCodiINE);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmABMMunicipis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMTerritoris";
            this.Load += new System.EventHandler(this.FrmABMMunicipis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHabitants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbCodiIne;
        private System.Windows.Forms.Label lbCodiINE;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.ComboBox cbCodiComarcas;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Label lbWeb;
        private System.Windows.Forms.Label lbCentreLatitud;
        private System.Windows.Forms.Label lbCentreLongitud;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbBandera;
        private System.Windows.Forms.Label lbEscut;
        private System.Windows.Forms.Label lbCodiComarca;
        private System.Windows.Forms.Label lbHabitants;
        private System.Windows.Forms.NumericUpDown nudHabitants;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.TextBox tbBandera;
        private System.Windows.Forms.TextBox tbEscut;
        private System.Windows.Forms.TextBox tbWeb;
        private System.Windows.Forms.TextBox tbCentreLat;
        private System.Windows.Forms.TextBox tbCentreLong;
        private System.Windows.Forms.TextBox tbNom;
    }
}