namespace AppSwissTransport
{
    partial class Fahrplan
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
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.dgvFahrplan = new System.Windows.Forms.DataGridView();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVerbindungen = new System.Windows.Forms.Label();
            this.cbAbfahrt = new System.Windows.Forms.ComboBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.cbAnkunft = new System.Windows.Forms.ComboBox();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnVon = new System.Windows.Forms.Button();
            this.btnNach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFahrplan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(44, 49);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(29, 13);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von:";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(47, 90);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(36, 13);
            this.lblNach.TabIndex = 2;
            this.lblNach.Text = "Nach:";
            // 
            // dgvFahrplan
            // 
            this.dgvFahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFahrplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Ankunft,
            this.Gleis});
            this.dgvFahrplan.Location = new System.Drawing.Point(111, 177);
            this.dgvFahrplan.Name = "dgvFahrplan";
            this.dgvFahrplan.Size = new System.Drawing.Size(443, 145);
            this.dgvFahrplan.TabIndex = 4;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.Name = "Abfahrt";
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.Name = "Ankunft";
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            // 
            // lblVerbindungen
            // 
            this.lblVerbindungen.AutoSize = true;
            this.lblVerbindungen.Location = new System.Drawing.Point(29, 199);
            this.lblVerbindungen.Name = "lblVerbindungen";
            this.lblVerbindungen.Size = new System.Drawing.Size(76, 13);
            this.lblVerbindungen.TabIndex = 5;
            this.lblVerbindungen.Text = "Verbindungen:";
            // 
            // cbAbfahrt
            // 
            this.cbAbfahrt.FormattingEnabled = true;
            this.cbAbfahrt.Location = new System.Drawing.Point(109, 46);
            this.cbAbfahrt.Name = "cbAbfahrt";
            this.cbAbfahrt.Size = new System.Drawing.Size(130, 21);
            this.cbAbfahrt.TabIndex = 7;
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(111, 147);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(283, 24);
            this.btnSuche.TabIndex = 8;
            this.btnSuche.Text = "Verbindungen Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // cbAnkunft
            // 
            this.cbAnkunft.FormattingEnabled = true;
            this.cbAnkunft.Location = new System.Drawing.Point(109, 82);
            this.cbAnkunft.Name = "cbAnkunft";
            this.cbAnkunft.Size = new System.Drawing.Size(130, 21);
            this.cbAnkunft.TabIndex = 9;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(109, 345);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(127, 33);
            this.btnAbfahrtstafel.TabIndex = 10;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnVon
            // 
            this.btnVon.Location = new System.Drawing.Point(306, 46);
            this.btnVon.Name = "btnVon";
            this.btnVon.Size = new System.Drawing.Size(75, 23);
            this.btnVon.TabIndex = 11;
            this.btnVon.Text = "Suchen";
            this.btnVon.UseVisualStyleBackColor = true;
            this.btnVon.Click += new System.EventHandler(this.btnVon_Click);
            // 
            // btnNach
            // 
            this.btnNach.Location = new System.Drawing.Point(306, 85);
            this.btnNach.Name = "btnNach";
            this.btnNach.Size = new System.Drawing.Size(75, 23);
            this.btnNach.TabIndex = 12;
            this.btnNach.Text = "Suchen";
            this.btnNach.UseVisualStyleBackColor = true;
            this.btnNach.Click += new System.EventHandler(this.btnNach_Click);
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 413);
            this.Controls.Add(this.btnNach);
            this.Controls.Add(this.btnVon);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.cbAnkunft);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.cbAbfahrt);
            this.Controls.Add(this.lblVerbindungen);
            this.Controls.Add(this.dgvFahrplan);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblVon);
            this.Name = "Fahrplan";
            this.Text = "ö";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFahrplan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.DataGridView dgvFahrplan;
        private System.Windows.Forms.Label lblVerbindungen;
        private System.Windows.Forms.ComboBox cbAbfahrt;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.ComboBox cbAnkunft;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnVon;
        private System.Windows.Forms.Button btnNach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
    }
}

