
namespace zadanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwaBadania = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonWyslij = new System.Windows.Forms.Button();
            this.buttonp = new System.Windows.Forms.Button();
            this.buttonn = new System.Windows.Forms.Button();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelBadania = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonspdate = new System.Windows.Forms.Button();
            this.buttonusun = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttontxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(40, 30);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 0;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNazwaBadania
            // 
            this.textBoxNazwaBadania.Location = new System.Drawing.Point(40, 78);
            this.textBoxNazwaBadania.Name = "textBoxNazwaBadania";
            this.textBoxNazwaBadania.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwaBadania.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nazwa badania";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(200, 33);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Czas";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(200, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date";
            this.labelDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonWyslij
            // 
            this.buttonWyslij.Location = new System.Drawing.Point(40, 153);
            this.buttonWyslij.Name = "buttonWyslij";
            this.buttonWyslij.Size = new System.Drawing.Size(200, 23);
            this.buttonWyslij.TabIndex = 6;
            this.buttonWyslij.Text = "Wyślij  Dane";
            this.buttonWyslij.UseVisualStyleBackColor = true;
            this.buttonWyslij.Click += new System.EventHandler(this.buttonWyslij_Click);
            // 
            // buttonp
            // 
            this.buttonp.Location = new System.Drawing.Point(513, 223);
            this.buttonp.Name = "buttonp";
            this.buttonp.Size = new System.Drawing.Size(75, 36);
            this.buttonp.TabIndex = 7;
            this.buttonp.Text = "poprzedni";
            this.buttonp.UseVisualStyleBackColor = true;
            // 
            // buttonn
            // 
            this.buttonn.Location = new System.Drawing.Point(594, 223);
            this.buttonn.Name = "buttonn";
            this.buttonn.Size = new System.Drawing.Size(75, 36);
            this.buttonn.TabIndex = 8;
            this.buttonn.Text = "nastepny";
            this.buttonn.UseVisualStyleBackColor = true;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(576, 107);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(26, 13);
            this.labelImie.TabIndex = 9;
            this.labelImie.Text = "Imie";
            // 
            // labelBadania
            // 
            this.labelBadania.AutoSize = true;
            this.labelBadania.Location = new System.Drawing.Point(576, 137);
            this.labelBadania.Name = "labelBadania";
            this.labelBadania.Size = new System.Drawing.Size(46, 13);
            this.labelBadania.TabIndex = 10;
            this.labelBadania.Text = "Badania";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(576, 163);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Data";
            // 
            // buttonspdate
            // 
            this.buttonspdate.Location = new System.Drawing.Point(693, 223);
            this.buttonspdate.Name = "buttonspdate";
            this.buttonspdate.Size = new System.Drawing.Size(85, 36);
            this.buttonspdate.TabIndex = 12;
            this.buttonspdate.Text = "sprawdz za ile badanie";
            this.buttonspdate.UseVisualStyleBackColor = true;
            // 
            // buttonusun
            // 
            this.buttonusun.BackColor = System.Drawing.SystemColors.Info;
            this.buttonusun.Location = new System.Drawing.Point(594, 287);
            this.buttonusun.Name = "buttonusun";
            this.buttonusun.Size = new System.Drawing.Size(75, 32);
            this.buttonusun.TabIndex = 13;
            this.buttonusun.Text = "usun";
            this.buttonusun.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttontxt
            // 
            this.buttontxt.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttontxt.Location = new System.Drawing.Point(693, 287);
            this.buttontxt.Name = "buttontxt";
            this.buttontxt.Size = new System.Drawing.Size(75, 32);
            this.buttontxt.TabIndex = 14;
            this.buttontxt.Text = "kolejka to txt";
            this.buttontxt.UseVisualStyleBackColor = false;
            this.buttontxt.Click += new System.EventHandler(this.buttontxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttontxt);
            this.Controls.Add(this.buttonusun);
            this.Controls.Add(this.buttonspdate);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelBadania);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.buttonn);
            this.Controls.Add(this.buttonp);
            this.Controls.Add(this.buttonWyslij);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNazwaBadania);
            this.Controls.Add(this.textBoxImie);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwaBadania;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonWyslij;
        private System.Windows.Forms.Button buttonp;
        private System.Windows.Forms.Button buttonn;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelBadania;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonspdate;
        private System.Windows.Forms.Button buttonusun;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttontxt;
    }
}

