namespace DAM_CRUDTerritoris.FORMULARIS {
    partial class FrmComPerHab {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.nudHabitants = new System.Windows.Forms.NumericUpDown();
            this.lbHabitants = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHabitants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(12, 59);
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(584, 366);
            this.dgDades.TabIndex = 12;
            // 
            // nudHabitants
            // 
            this.nudHabitants.Location = new System.Drawing.Point(136, 23);
            this.nudHabitants.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudHabitants.Name = "nudHabitants";
            this.nudHabitants.Size = new System.Drawing.Size(410, 20);
            this.nudHabitants.TabIndex = 18;
            this.nudHabitants.ValueChanged += new System.EventHandler(this.nudHabitants_ValueChanged);
            // 
            // lbHabitants
            // 
            this.lbHabitants.AutoSize = true;
            this.lbHabitants.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbHabitants.ForeColor = System.Drawing.Color.White;
            this.lbHabitants.Location = new System.Drawing.Point(12, 23);
            this.lbHabitants.MinimumSize = new System.Drawing.Size(118, 0);
            this.lbHabitants.Name = "lbHabitants";
            this.lbHabitants.Padding = new System.Windows.Forms.Padding(3);
            this.lbHabitants.Size = new System.Drawing.Size(118, 19);
            this.lbHabitants.TabIndex = 17;
            this.lbHabitants.Text = "Habitants (min)";
            // 
            // FrmComPerHab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.nudHabitants);
            this.Controls.Add(this.lbHabitants);
            this.Controls.Add(this.dgDades);
            this.Name = "FrmComPerHab";
            this.Text = "FrmComPerHab";
            this.Load += new System.EventHandler(this.FrmComPerHab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHabitants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.NumericUpDown nudHabitants;
        private System.Windows.Forms.Label lbHabitants;
    }
}