namespace ProjektOS2
{
    partial class EnkripcijaForma
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
            this.odabirDrugo = new System.Windows.Forms.TextBox();
            this.labelaDrugo = new System.Windows.Forms.Label();
            this.labelaPrvo = new System.Windows.Forms.Label();
            this.odabirPrvo = new System.Windows.Forms.TextBox();
            this.gumbGeneriraj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.odabirAlgoritam = new System.Windows.Forms.ComboBox();
            this.gumbEnkriptiraj = new System.Windows.Forms.Button();
            this.prikazEnkriptirano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prikazOriginal = new System.Windows.Forms.TextBox();
            this.btn_ucitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // odabirDrugo
            // 
            this.odabirDrugo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odabirDrugo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabirDrugo.Location = new System.Drawing.Point(210, 311);
            this.odabirDrugo.Name = "odabirDrugo";
            this.odabirDrugo.Size = new System.Drawing.Size(562, 26);
            this.odabirDrugo.TabIndex = 15;
            // 
            // labelaDrugo
            // 
            this.labelaDrugo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaDrugo.AutoSize = true;
            this.labelaDrugo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaDrugo.Location = new System.Drawing.Point(136, 311);
            this.labelaDrugo.Name = "labelaDrugo";
            this.labelaDrugo.Size = new System.Drawing.Size(29, 20);
            this.labelaDrugo.TabIndex = 14;
            this.labelaDrugo.Text = "IV:";
            // 
            // labelaPrvo
            // 
            this.labelaPrvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaPrvo.AutoSize = true;
            this.labelaPrvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaPrvo.Location = new System.Drawing.Point(136, 282);
            this.labelaPrvo.Name = "labelaPrvo";
            this.labelaPrvo.Size = new System.Drawing.Size(50, 20);
            this.labelaPrvo.TabIndex = 13;
            this.labelaPrvo.Text = "Tajni:";
            // 
            // odabirPrvo
            // 
            this.odabirPrvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odabirPrvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabirPrvo.Location = new System.Drawing.Point(210, 282);
            this.odabirPrvo.Name = "odabirPrvo";
            this.odabirPrvo.Size = new System.Drawing.Size(562, 26);
            this.odabirPrvo.TabIndex = 12;
            // 
            // gumbGeneriraj
            // 
            this.gumbGeneriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbGeneriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbGeneriraj.Location = new System.Drawing.Point(135, 247);
            this.gumbGeneriraj.Name = "gumbGeneriraj";
            this.gumbGeneriraj.Size = new System.Drawing.Size(212, 29);
            this.gumbGeneriraj.TabIndex = 11;
            this.gumbGeneriraj.Text = "Generiraj ključeve";
            this.gumbGeneriraj.UseVisualStyleBackColor = true;
            this.gumbGeneriraj.Click += new System.EventHandler(this.gumbGeneriraj_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(131, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Odabir enkripcijskog algoritma:";
            // 
            // odabirAlgoritam
            // 
            this.odabirAlgoritam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odabirAlgoritam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabirAlgoritam.FormattingEnabled = true;
            this.odabirAlgoritam.Location = new System.Drawing.Point(377, 206);
            this.odabirAlgoritam.Name = "odabirAlgoritam";
            this.odabirAlgoritam.Size = new System.Drawing.Size(217, 28);
            this.odabirAlgoritam.TabIndex = 9;
            this.odabirAlgoritam.SelectedIndexChanged += new System.EventHandler(this.odabirAlgoritam_SelectedIndexChanged);
            // 
            // gumbEnkriptiraj
            // 
            this.gumbEnkriptiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbEnkriptiraj.Enabled = false;
            this.gumbEnkriptiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbEnkriptiraj.Location = new System.Drawing.Point(427, 552);
            this.gumbEnkriptiraj.Name = "gumbEnkriptiraj";
            this.gumbEnkriptiraj.Size = new System.Drawing.Size(167, 38);
            this.gumbEnkriptiraj.TabIndex = 20;
            this.gumbEnkriptiraj.Text = "Enkriptiraj";
            this.gumbEnkriptiraj.UseVisualStyleBackColor = true;
            this.gumbEnkriptiraj.Click += new System.EventHandler(this.gumbEnkriptiraj_Click);
            // 
            // prikazEnkriptirano
            // 
            this.prikazEnkriptirano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prikazEnkriptirano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazEnkriptirano.Location = new System.Drawing.Point(504, 421);
            this.prikazEnkriptirano.Multiline = true;
            this.prikazEnkriptirano.Name = "prikazEnkriptirano";
            this.prikazEnkriptirano.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prikazEnkriptirano.Size = new System.Drawing.Size(358, 125);
            this.prikazEnkriptirano.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(500, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enkriptirani Tekst:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Originalni Tekst:";
            // 
            // prikazOriginal
            // 
            this.prikazOriginal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prikazOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazOriginal.Location = new System.Drawing.Point(135, 422);
            this.prikazOriginal.Multiline = true;
            this.prikazOriginal.Name = "prikazOriginal";
            this.prikazOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prikazOriginal.Size = new System.Drawing.Size(363, 124);
            this.prikazOriginal.TabIndex = 16;
            // 
            // btn_ucitaj
            // 
            this.btn_ucitaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ucitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ucitaj.Location = new System.Drawing.Point(135, 367);
            this.btn_ucitaj.Name = "btn_ucitaj";
            this.btn_ucitaj.Size = new System.Drawing.Size(212, 29);
            this.btn_ucitaj.TabIndex = 21;
            this.btn_ucitaj.Text = "Učitaj datoteku";
            this.btn_ucitaj.UseVisualStyleBackColor = true;
            this.btn_ucitaj.Click += new System.EventHandler(this.btn_ucitaj_Click);
            // 
            // EnkripcijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 738);
            this.Controls.Add(this.btn_ucitaj);
            this.Controls.Add(this.gumbEnkriptiraj);
            this.Controls.Add(this.prikazEnkriptirano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prikazOriginal);
            this.Controls.Add(this.odabirDrugo);
            this.Controls.Add(this.labelaDrugo);
            this.Controls.Add(this.labelaPrvo);
            this.Controls.Add(this.odabirPrvo);
            this.Controls.Add(this.gumbGeneriraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odabirAlgoritam);
            this.Name = "EnkripcijaForma";
            this.Text = "EnkripcijaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox odabirDrugo;
        private System.Windows.Forms.Label labelaDrugo;
        private System.Windows.Forms.Label labelaPrvo;
        private System.Windows.Forms.TextBox odabirPrvo;
        private System.Windows.Forms.Button gumbGeneriraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox odabirAlgoritam;
        private System.Windows.Forms.Button gumbEnkriptiraj;
        private System.Windows.Forms.TextBox prikazEnkriptirano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prikazOriginal;
        private System.Windows.Forms.Button btn_ucitaj;
    }
}