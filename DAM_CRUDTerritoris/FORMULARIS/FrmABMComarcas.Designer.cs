namespace DAM_CRUDTerritoris.FORMULARIS {
    partial class FrmABMComarcas {
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
            this.lbNom = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.lbCodiComarca = new System.Windows.Forms.Label();
            this.lbHabitants = new System.Windows.Forms.Label();
            this.nudHabitants = new System.Windows.Forms.NumericUpDown();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.nudExtensio = new System.Windows.Forms.NumericUpDown();
            this.lbExtension = new System.Windows.Forms.Label();
            this.tbCodiComarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHabitants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtensio)).BeginInit();
            this.SuspendLayout();
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
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(179, 187);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(114, 46);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(342, 187);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(114, 46);
            this.btNo.TabIndex = 7;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // lbCodiComarca
            // 
            this.lbCodiComarca.AutoSize = true;
            this.lbCodiComarca.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbCodiComarca.ForeColor = System.Drawing.Color.White;
            this.lbCodiComarca.Location = new System.Drawing.Point(28, 50);
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
            this.lbHabitants.Location = new System.Drawing.Point(28, 113);
            this.lbHabitants.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbHabitants.Name = "lbHabitants";
            this.lbHabitants.Padding = new System.Windows.Forms.Padding(3);
            this.lbHabitants.Size = new System.Drawing.Size(118, 22);
            this.lbHabitants.TabIndex = 14;
            this.lbHabitants.Text = "Habitants";
            // 
            // nudHabitants
            // 
            this.nudHabitants.Location = new System.Drawing.Point(149, 111);
            this.nudHabitants.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudHabitants.Name = "nudHabitants";
            this.nudHabitants.Size = new System.Drawing.Size(410, 23);
            this.nudHabitants.TabIndex = 16;
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
            // nudExtensio
            // 
            this.nudExtensio.Location = new System.Drawing.Point(149, 144);
            this.nudExtensio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudExtensio.Name = "nudExtensio";
            this.nudExtensio.Size = new System.Drawing.Size(410, 23);
            this.nudExtensio.TabIndex = 25;
            // 
            // lbExtension
            // 
            this.lbExtension.AutoSize = true;
            this.lbExtension.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbExtension.ForeColor = System.Drawing.Color.White;
            this.lbExtension.Location = new System.Drawing.Point(28, 146);
            this.lbExtension.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbExtension.Name = "lbExtension";
            this.lbExtension.Padding = new System.Windows.Forms.Padding(3);
            this.lbExtension.Size = new System.Drawing.Size(118, 22);
            this.lbExtension.TabIndex = 24;
            this.lbExtension.Text = "Extensio";
            // 
            // tbCodiComarca
            // 
            this.tbCodiComarca.Location = new System.Drawing.Point(149, 49);
            this.tbCodiComarca.MaxLength = 20;
            this.tbCodiComarca.Name = "tbCodiComarca";
            this.tbCodiComarca.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCodiComarca.Size = new System.Drawing.Size(412, 23);
            this.tbCodiComarca.TabIndex = 26;
            this.tbCodiComarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmABMComarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(580, 238);
            this.Controls.Add(this.tbCodiComarca);
            this.Controls.Add(this.nudExtensio);
            this.Controls.Add(this.lbExtension);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.nudHabitants);
            this.Controls.Add(this.lbCodiComarca);
            this.Controls.Add(this.lbHabitants);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbNom);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmABMComarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMTerritoris";
            this.Load += new System.EventHandler(this.FrmABMComarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHabitants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtensio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Label lbCodiComarca;
        private System.Windows.Forms.Label lbHabitants;
        private System.Windows.Forms.NumericUpDown nudHabitants;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.NumericUpDown nudExtensio;
        private System.Windows.Forms.Label lbExtension;
        private System.Windows.Forms.TextBox tbCodiComarca;
    }
}