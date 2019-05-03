namespace ProjektOS2
{
    partial class SazetakForma
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
            this.btn_ucitaj = new System.Windows.Forms.Button();
            this.box_sazetak = new System.Windows.Forms.TextBox();
            this.labelaSazetak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ucitaj
            // 
            this.btn_ucitaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ucitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ucitaj.Location = new System.Drawing.Point(202, 92);
            this.btn_ucitaj.Name = "btn_ucitaj";
            this.btn_ucitaj.Size = new System.Drawing.Size(391, 29);
            this.btn_ucitaj.TabIndex = 22;
            this.btn_ucitaj.Text = "Učitaj datoteku i izračunaj sažetak";
            this.btn_ucitaj.UseVisualStyleBackColor = true;
            this.btn_ucitaj.Click += new System.EventHandler(this.btn_ucitaj_Click);
            // 
            // box_sazetak
            // 
            this.box_sazetak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box_sazetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.box_sazetak.Location = new System.Drawing.Point(202, 127);
            this.box_sazetak.Name = "box_sazetak";
            this.box_sazetak.Size = new System.Drawing.Size(562, 26);
            this.box_sazetak.TabIndex = 23;
            // 
            // labelaSazetak
            // 
            this.labelaSazetak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaSazetak.AutoSize = true;
            this.labelaSazetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaSazetak.Location = new System.Drawing.Point(122, 130);
            this.labelaSazetak.Name = "labelaSazetak";
            this.labelaSazetak.Size = new System.Drawing.Size(74, 20);
            this.labelaSazetak.TabIndex = 24;
            this.labelaSazetak.Text = "Sažetak:";
            // 
            // SazetakForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 517);
            this.Controls.Add(this.labelaSazetak);
            this.Controls.Add(this.box_sazetak);
            this.Controls.Add(this.btn_ucitaj);
            this.Name = "SazetakForma";
            this.Text = "SazetakForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ucitaj;
        private System.Windows.Forms.TextBox box_sazetak;
        private System.Windows.Forms.Label labelaSazetak;
    }
}