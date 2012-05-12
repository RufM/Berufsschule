namespace _20120509_Konto_mit_GUI
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
            this.tbxinhaber = new System.Windows.Forms.TextBox();
            this.btngetInhaber = new System.Windows.Forms.Button();
            this.btncreateInhaber = new System.Windows.Forms.Button();
            this.tbxkontoNummer = new System.Windows.Forms.TextBox();
            this.tbxkontoStand = new System.Windows.Forms.TextBox();
            this.tbxbetrag = new System.Windows.Forms.TextBox();
            this.btneinzahlen = new System.Windows.Forms.Button();
            this.btnauszahlen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxinhaber
            // 
            this.tbxinhaber.Location = new System.Drawing.Point(13, 13);
            this.tbxinhaber.Name = "tbxinhaber";
            this.tbxinhaber.Size = new System.Drawing.Size(100, 20);
            this.tbxinhaber.TabIndex = 0;
            // 
            // btngetInhaber
            // 
            this.btngetInhaber.Location = new System.Drawing.Point(119, 13);
            this.btngetInhaber.Name = "btngetInhaber";
            this.btngetInhaber.Size = new System.Drawing.Size(75, 23);
            this.btngetInhaber.TabIndex = 1;
            this.btngetInhaber.Text = "Suchen";
            this.btngetInhaber.UseVisualStyleBackColor = true;
            this.btngetInhaber.Click += new System.EventHandler(this.btngetInhaber_Click);
            // 
            // btncreateInhaber
            // 
            this.btncreateInhaber.Location = new System.Drawing.Point(200, 13);
            this.btncreateInhaber.Name = "btncreateInhaber";
            this.btncreateInhaber.Size = new System.Drawing.Size(75, 23);
            this.btncreateInhaber.TabIndex = 2;
            this.btncreateInhaber.Text = "Erstellen";
            this.btncreateInhaber.UseVisualStyleBackColor = true;
            this.btncreateInhaber.Click += new System.EventHandler(this.btncreateInhaber_Click);
            // 
            // tbxkontoNummer
            // 
            this.tbxkontoNummer.Location = new System.Drawing.Point(13, 71);
            this.tbxkontoNummer.Name = "tbxkontoNummer";
            this.tbxkontoNummer.Size = new System.Drawing.Size(100, 20);
            this.tbxkontoNummer.TabIndex = 3;
            // 
            // tbxkontoStand
            // 
            this.tbxkontoStand.Location = new System.Drawing.Point(119, 71);
            this.tbxkontoStand.Name = "tbxkontoStand";
            this.tbxkontoStand.Size = new System.Drawing.Size(153, 20);
            this.tbxkontoStand.TabIndex = 4;
            // 
            // tbxbetrag
            // 
            this.tbxbetrag.Location = new System.Drawing.Point(13, 147);
            this.tbxbetrag.Name = "tbxbetrag";
            this.tbxbetrag.Size = new System.Drawing.Size(100, 20);
            this.tbxbetrag.TabIndex = 5;
            // 
            // btneinzahlen
            // 
            this.btneinzahlen.Location = new System.Drawing.Point(120, 143);
            this.btneinzahlen.Name = "btneinzahlen";
            this.btneinzahlen.Size = new System.Drawing.Size(75, 23);
            this.btneinzahlen.TabIndex = 6;
            this.btneinzahlen.Text = "Einzahlen";
            this.btneinzahlen.UseVisualStyleBackColor = true;
            this.btneinzahlen.Click += new System.EventHandler(this.btneinzahlen_Click);
            // 
            // btnauszahlen
            // 
            this.btnauszahlen.Location = new System.Drawing.Point(120, 173);
            this.btnauszahlen.Name = "btnauszahlen";
            this.btnauszahlen.Size = new System.Drawing.Size(75, 23);
            this.btnauszahlen.TabIndex = 7;
            this.btnauszahlen.Text = "Auszahlen";
            this.btnauszahlen.UseVisualStyleBackColor = true;
            this.btnauszahlen.Click += new System.EventHandler(this.btnauszahlen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnauszahlen);
            this.Controls.Add(this.btneinzahlen);
            this.Controls.Add(this.tbxbetrag);
            this.Controls.Add(this.tbxkontoStand);
            this.Controls.Add(this.tbxkontoNummer);
            this.Controls.Add(this.btncreateInhaber);
            this.Controls.Add(this.btngetInhaber);
            this.Controls.Add(this.tbxinhaber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxinhaber;
        private System.Windows.Forms.Button btngetInhaber;
        private System.Windows.Forms.Button btncreateInhaber;
        private System.Windows.Forms.TextBox tbxkontoNummer;
        private System.Windows.Forms.TextBox tbxkontoStand;
        private System.Windows.Forms.TextBox tbxbetrag;
        private System.Windows.Forms.Button btneinzahlen;
        private System.Windows.Forms.Button btnauszahlen;
    }
}

