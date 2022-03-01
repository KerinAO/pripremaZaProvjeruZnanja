namespace pripremaZaProvjeruZnanja
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
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dtpGodPro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.trckSnaga = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSnaga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Location = new System.Drawing.Point(12, 244);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.Size = new System.Drawing.Size(270, 131);
            this.rtxtIspis.TabIndex = 0;
            this.rtxtIspis.Text = "";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(25, 386);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(104, 42);
            this.btnUnesi.TabIndex = 1;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(164, 386);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(104, 42);
            this.btnIspis.TabIndex = 2;
            this.btnIspis.Text = "Ispiši";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Automobil",
            "JetSki",
            "Zrakomlat"});
            this.cmbVrsta.Location = new System.Drawing.Point(88, 11);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(127, 21);
            this.cmbVrsta.TabIndex = 3;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(88, 46);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(127, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // dtpGodPro
            // 
            this.dtpGodPro.Location = new System.Drawing.Point(15, 142);
            this.dtpGodPro.Name = "dtpGodPro";
            this.dtpGodPro.Size = new System.Drawing.Size(200, 20);
            this.dtpGodPro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vrsta vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv vozila:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Godina Proizvodnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marka vozila:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(88, 83);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(127, 20);
            this.txtMarka.TabIndex = 10;
            // 
            // trckSnaga
            // 
            this.trckSnaga.LargeChange = 20;
            this.trckSnaga.Location = new System.Drawing.Point(15, 193);
            this.trckSnaga.Maximum = 350;
            this.trckSnaga.Minimum = 45;
            this.trckSnaga.Name = "trckSnaga";
            this.trckSnaga.Size = new System.Drawing.Size(200, 45);
            this.trckSnaga.SmallChange = 5;
            this.trckSnaga.TabIndex = 11;
            this.trckSnaga.Value = 45;
            this.trckSnaga.Scroll += new System.EventHandler(this.trckSnaga_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Snaga motora:";
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.Location = new System.Drawing.Point(95, 176);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(19, 13);
            this.lblSnaga.TabIndex = 13;
            this.lblSnaga.Text = "45";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 450);
            this.Controls.Add(this.lblSnaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trckSnaga);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpGodPro);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.rtxtIspis);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DateTimePicker dtpGodPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TrackBar trckSnaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSnaga;
    }
}

