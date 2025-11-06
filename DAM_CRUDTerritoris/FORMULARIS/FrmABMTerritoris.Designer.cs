namespace DAM_CRUDTerritoris.FORMULARIS
{
    partial class FrmABMTerritoris
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
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDescripcio = new System.Windows.Forms.TextBox();
            this.lbDescripcio = new System.Windows.Forms.Label();
            this.lbRegio = new System.Windows.Forms.Label();
            this.cbRegions = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(28, 21);
            this.lbId.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(3);
            this.lbId.Size = new System.Drawing.Size(100, 22);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id.";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(135, 21);
            this.tbId.MaxLength = 20;
            this.tbId.Name = "tbId";
            this.tbId.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbId.Size = new System.Drawing.Size(188, 23);
            this.tbId.TabIndex = 1;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDescripcio
            // 
            this.tbDescripcio.Location = new System.Drawing.Point(135, 50);
            this.tbDescripcio.MaxLength = 50;
            this.tbDescripcio.Name = "tbDescripcio";
            this.tbDescripcio.Size = new System.Drawing.Size(418, 23);
            this.tbDescripcio.TabIndex = 3;
            // 
            // lbDescripcio
            // 
            this.lbDescripcio.AutoSize = true;
            this.lbDescripcio.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbDescripcio.ForeColor = System.Drawing.Color.White;
            this.lbDescripcio.Location = new System.Drawing.Point(28, 50);
            this.lbDescripcio.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbDescripcio.Name = "lbDescripcio";
            this.lbDescripcio.Padding = new System.Windows.Forms.Padding(3);
            this.lbDescripcio.Size = new System.Drawing.Size(100, 22);
            this.lbDescripcio.TabIndex = 2;
            this.lbDescripcio.Text = "Descripció";
            // 
            // lbRegio
            // 
            this.lbRegio.AutoSize = true;
            this.lbRegio.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbRegio.ForeColor = System.Drawing.Color.White;
            this.lbRegio.Location = new System.Drawing.Point(28, 81);
            this.lbRegio.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(3);
            this.lbRegio.Size = new System.Drawing.Size(100, 22);
            this.lbRegio.TabIndex = 4;
            this.lbRegio.Text = "Regió";
            // 
            // cbRegions
            // 
            this.cbRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(135, 81);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(427, 24);
            this.cbRegions.TabIndex = 5;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(179, 116);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(114, 42);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(342, 116);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(114, 42);
            this.btNo.TabIndex = 7;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // FrmABMTerritoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(580, 170);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbRegions);
            this.Controls.Add(this.lbRegio);
            this.Controls.Add(this.tbDescripcio);
            this.Controls.Add(this.lbDescripcio);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmABMTerritoris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMTerritoris";
            this.Load += new System.EventHandler(this.FrmABMTerritoris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDescripcio;
        private System.Windows.Forms.Label lbDescripcio;
        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.ComboBox cbRegions;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btNo;
    }
}