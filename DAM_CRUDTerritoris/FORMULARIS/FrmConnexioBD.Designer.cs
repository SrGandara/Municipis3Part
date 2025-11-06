namespace DAM_CRUDTerritoris.FORMULARIS
{
    partial class FrmConnexioBD
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
            this.lbBD = new System.Windows.Forms.Label();
            this.tbCadenaConnexio = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.lbTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBD
            // 
            this.lbBD.AutoSize = true;
            this.lbBD.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbBD.ForeColor = System.Drawing.Color.White;
            this.lbBD.Location = new System.Drawing.Point(24, 26);
            this.lbBD.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbBD.Name = "lbBD";
            this.lbBD.Padding = new System.Windows.Forms.Padding(3);
            this.lbBD.Size = new System.Drawing.Size(146, 22);
            this.lbBD.TabIndex = 1;
            this.lbBD.Text = "Cadena de connexió";
            // 
            // tbCadenaConnexio
            // 
            this.tbCadenaConnexio.Location = new System.Drawing.Point(176, 26);
            this.tbCadenaConnexio.MaxLength = 1024;
            this.tbCadenaConnexio.Name = "tbCadenaConnexio";
            this.tbCadenaConnexio.Size = new System.Drawing.Size(747, 23);
            this.tbCadenaConnexio.TabIndex = 4;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(432, 108);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(114, 42);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTip.Location = new System.Drawing.Point(176, 72);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(416, 16);
            this.lbTip.TabIndex = 8;
            this.lbTip.Text = "(*) Recorda que la cadena de connexió ha d\'estar encriptada";
            // 
            // FrmConnexioBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(965, 162);
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbCadenaConnexio);
            this.Controls.Add(this.lbBD);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnexioBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexió amb la Base de Dades";
            this.Load += new System.EventHandler(this.FrmConnexioBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBD;
        private System.Windows.Forms.TextBox tbCadenaConnexio;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbTip;
    }
}