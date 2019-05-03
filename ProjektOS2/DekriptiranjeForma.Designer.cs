namespace ProjektOS2
{
    partial class DekriptiranjeForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.odabirAlgoritam = new System.Windows.Forms.ComboBox();
            this.btn_ucitaj = new System.Windows.Forms.Button();
            this.prikazEnkriptirano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prikazOriginal = new System.Windows.Forms.TextBox();
            this.gumbDekriptiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(210, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Odabir enkripcijskog algoritma:";
            // 
            // odabirAlgoritam
            // 
            this.odabirAlgoritam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odabirAlgoritam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabirAlgoritam.FormattingEnabled = true;
            this.odabirAlgoritam.Location = new System.Drawing.Point(456, 70);
            this.odabirAlgoritam.Name = "odabirAlgoritam";
            this.odabirAlgoritam.Size = new System.Drawing.Size(217, 28);
            this.odabirAlgoritam.TabIndex = 11;
            this.odabirAlgoritam.SelectedIndexChanged += new System.EventHandler(this.odabirAlgoritam_SelectedIndexChanged);
            // 
            // btn_ucitaj
            // 
            this.btn_ucitaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ucitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ucitaj.Location = new System.Drawing.Point(214, 109);
            this.btn_ucitaj.Name = "btn_ucitaj";
            this.btn_ucitaj.Size = new System.Drawing.Size(212, 29);
            this.btn_ucitaj.TabIndex = 22;
            this.btn_ucitaj.Text = "Učitaj datoteku";
            this.btn_ucitaj.UseVisualStyleBackColor = true;
            this.btn_ucitaj.Click += new System.EventHandler(this.btn_ucitaj_Click);
            // 
            // prikazEnkriptirano
            // 
            this.prikazEnkriptirano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prikazEnkriptirano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazEnkriptirano.Location = new System.Drawing.Point(92, 179);
            this.prikazEnkriptirano.Multiline = true;
            this.prikazEnkriptirano.Name = "prikazEnkriptirano";
            this.prikazEnkriptirano.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prikazEnkriptirano.Size = new System.Drawing.Size(358, 125);
            this.prikazEnkriptirano.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(88, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Enkriptirani Tekst:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(452, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Originalni Tekst:";
            // 
            // prikazOriginal
            // 
            this.prikazOriginal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prikazOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazOriginal.Location = new System.Drawing.Point(456, 180);
            this.prikazOriginal.Multiline = true;
            this.prikazOriginal.Name = "prikazOriginal";
            this.prikazOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prikazOriginal.Size = new System.Drawing.Size(363, 124);
            this.prikazOriginal.TabIndex = 25;
            // 
            // gumbDekriptiraj
            // 
            this.gumbDekriptiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbDekriptiraj.Enabled = false;
            this.gumbDekriptiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbDekriptiraj.Location = new System.Drawing.Point(375, 310);
            this.gumbDekriptiraj.Name = "gumbDekriptiraj";
            this.gumbDekriptiraj.Size = new System.Drawing.Size(167, 38);
            this.gumbDekriptiraj.TabIndex = 27;
            this.gumbDekriptiraj.Text = "Dekriptiraj";
            this.gumbDekriptiraj.UseVisualStyleBackColor = true;
            this.gumbDekriptiraj.Click += new System.EventHandler(this.gumbDekriptiraj_Click);
            // 
            // DekriptiranjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 496);
            this.Controls.Add(this.gumbDekriptiraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prikazOriginal);
            this.Controls.Add(this.prikazEnkriptirano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ucitaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odabirAlgoritam);
            this.Name = "DekriptiranjeForma";
            this.Text = "DekriptiranjeForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox odabirAlgoritam;
        private System.Windows.Forms.Button btn_ucitaj;
        private System.Windows.Forms.TextBox prikazEnkriptirano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prikazOriginal;
        private System.Windows.Forms.Button gumbDekriptiraj;
    }
}