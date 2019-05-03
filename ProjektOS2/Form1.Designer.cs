namespace ProjektOS2
{
    partial class Form1
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
            this.glavniPanel = new System.Windows.Forms.Panel();
            this.btn_enkripcija = new System.Windows.Forms.Button();
            this.btn_dekripcija = new System.Windows.Forms.Button();
            this.btn_sazetak = new System.Windows.Forms.Button();
            this.btn_potpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // glavniPanel
            // 
            this.glavniPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glavniPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.glavniPanel.Location = new System.Drawing.Point(125, 12);
            this.glavniPanel.Name = "glavniPanel";
            this.glavniPanel.Size = new System.Drawing.Size(897, 556);
            this.glavniPanel.TabIndex = 0;
            // 
            // btn_enkripcija
            // 
            this.btn_enkripcija.Location = new System.Drawing.Point(6, 13);
            this.btn_enkripcija.Name = "btn_enkripcija";
            this.btn_enkripcija.Size = new System.Drawing.Size(113, 41);
            this.btn_enkripcija.TabIndex = 1;
            this.btn_enkripcija.Text = "Enkriptiranje";
            this.btn_enkripcija.UseVisualStyleBackColor = true;
            this.btn_enkripcija.Click += new System.EventHandler(this.btn_enkripcija_Click);
            // 
            // btn_dekripcija
            // 
            this.btn_dekripcija.Location = new System.Drawing.Point(6, 60);
            this.btn_dekripcija.Name = "btn_dekripcija";
            this.btn_dekripcija.Size = new System.Drawing.Size(113, 41);
            this.btn_dekripcija.TabIndex = 2;
            this.btn_dekripcija.Text = "Dekriptiranje";
            this.btn_dekripcija.UseVisualStyleBackColor = true;
            this.btn_dekripcija.Click += new System.EventHandler(this.btn_dekripcija_Click);
            // 
            // btn_sazetak
            // 
            this.btn_sazetak.Location = new System.Drawing.Point(6, 107);
            this.btn_sazetak.Name = "btn_sazetak";
            this.btn_sazetak.Size = new System.Drawing.Size(113, 41);
            this.btn_sazetak.TabIndex = 3;
            this.btn_sazetak.Text = "Sažetak poruke";
            this.btn_sazetak.UseVisualStyleBackColor = true;
            this.btn_sazetak.Click += new System.EventHandler(this.btn_sazetak_Click);
            // 
            // btn_potpis
            // 
            this.btn_potpis.Location = new System.Drawing.Point(6, 154);
            this.btn_potpis.Name = "btn_potpis";
            this.btn_potpis.Size = new System.Drawing.Size(113, 41);
            this.btn_potpis.TabIndex = 4;
            this.btn_potpis.Text = "Digitalni potpis";
            this.btn_potpis.UseVisualStyleBackColor = true;
            this.btn_potpis.Click += new System.EventHandler(this.btn_potpis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 580);
            this.Controls.Add(this.btn_potpis);
            this.Controls.Add(this.btn_sazetak);
            this.Controls.Add(this.btn_dekripcija);
            this.Controls.Add(this.btn_enkripcija);
            this.Controls.Add(this.glavniPanel);
            this.MinimumSize = new System.Drawing.Size(1050, 619);
            this.Name = "Form1";
            this.Text = "Glavna Forma";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel glavniPanel;
        private System.Windows.Forms.Button btn_enkripcija;
        private System.Windows.Forms.Button btn_dekripcija;
        private System.Windows.Forms.Button btn_sazetak;
        private System.Windows.Forms.Button btn_potpis;
    }
}

