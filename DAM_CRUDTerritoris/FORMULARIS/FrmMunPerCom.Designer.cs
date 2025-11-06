namespace DAM_CRUDTerritoris.FORMULARIS {
    partial class FrmMunPerCom {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.lbCodiComarca = new System.Windows.Forms.Label();
            this.cbCodiComarcas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(12, 72);
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(584, 366);
            this.dgDades.TabIndex = 12;
            this.dgDades.DoubleClick += new System.EventHandler(this.dgDades_DoubleClick);
            // 
            // lbCodiComarca
            // 
            this.lbCodiComarca.AutoSize = true;
            this.lbCodiComarca.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbCodiComarca.ForeColor = System.Drawing.Color.White;
            this.lbCodiComarca.Location = new System.Drawing.Point(12, 29);
            this.lbCodiComarca.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbCodiComarca.Name = "lbCodiComarca";
            this.lbCodiComarca.Padding = new System.Windows.Forms.Padding(3);
            this.lbCodiComarca.Size = new System.Drawing.Size(118, 19);
            this.lbCodiComarca.TabIndex = 17;
            this.lbCodiComarca.Text = "Codi Comarca";
            // 
            // cbCodiComarcas
            // 
            this.cbCodiComarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodiComarcas.FormattingEnabled = true;
            this.cbCodiComarcas.Location = new System.Drawing.Point(134, 29);
            this.cbCodiComarcas.Name = "cbCodiComarcas";
            this.cbCodiComarcas.Size = new System.Drawing.Size(412, 21);
            this.cbCodiComarcas.TabIndex = 16;
            this.cbCodiComarcas.SelectedValueChanged += new System.EventHandler(this.cbCodiComarcas_SelectedValueChanged);
            // 
            // FrmMunPerCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.lbCodiComarca);
            this.Controls.Add(this.cbCodiComarcas);
            this.Controls.Add(this.dgDades);
            this.Name = "FrmMunPerCom";
            this.Text = "FrmMunPerCom";
            this.Load += new System.EventHandler(this.FrmMunPerCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.Label lbCodiComarca;
        private System.Windows.Forms.ComboBox cbCodiComarcas;
    }
}