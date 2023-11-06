namespace Dolar_1
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
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolar.Location = new System.Drawing.Point(31, 70);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(116, 18);
            this.lblDolar.TabIndex = 0;
            this.lblDolar.Text = "1 ABD DOLAR";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(31, 124);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(69, 18);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "MİKTAR";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(163, 70);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(129, 20);
            this.txtDolar.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(163, 125);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(129, 20);
            this.txtMiktar.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(127, 205);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(131, 58);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "HESPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(31, 304);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(62, 18);
            this.lblTutar.TabIndex = 5;
            this.lblTutar.Text = "TUTAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblDolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTutar;
    }
}

