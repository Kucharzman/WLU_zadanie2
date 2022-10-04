namespace WLU_zadanie2
{
    partial class formMain
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
            this.tabcSekretariat = new System.Windows.Forms.TabControl();
            this.pgSzukaj = new System.Windows.Forms.TabPage();
            this.tbLookedfor = new System.Windows.Forms.TextBox();
            this.cmbHow = new System.Windows.Forms.ComboBox();
            this.cmbWhat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pgDodaj = new System.Windows.Forms.TabPage();
            this.bttDodajUcznia = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttSzukaj = new System.Windows.Forms.Button();
            this.edtOut = new System.Windows.Forms.RichTextBox();
            this.tabcSekretariat.SuspendLayout();
            this.pgSzukaj.SuspendLayout();
            this.pgDodaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcSekretariat
            // 
            this.tabcSekretariat.Controls.Add(this.pgSzukaj);
            this.tabcSekretariat.Controls.Add(this.pgDodaj);
            this.tabcSekretariat.Location = new System.Drawing.Point(12, 12);
            this.tabcSekretariat.Name = "tabcSekretariat";
            this.tabcSekretariat.SelectedIndex = 0;
            this.tabcSekretariat.Size = new System.Drawing.Size(776, 426);
            this.tabcSekretariat.TabIndex = 1;
            // 
            // pgSzukaj
            // 
            this.pgSzukaj.BackColor = System.Drawing.SystemColors.Control;
            this.pgSzukaj.Controls.Add(this.edtOut);
            this.pgSzukaj.Controls.Add(this.bttSzukaj);
            this.pgSzukaj.Controls.Add(this.tbLookedfor);
            this.pgSzukaj.Controls.Add(this.cmbHow);
            this.pgSzukaj.Controls.Add(this.cmbWhat);
            this.pgSzukaj.Controls.Add(this.label4);
            this.pgSzukaj.Location = new System.Drawing.Point(4, 24);
            this.pgSzukaj.Name = "pgSzukaj";
            this.pgSzukaj.Padding = new System.Windows.Forms.Padding(3);
            this.pgSzukaj.Size = new System.Drawing.Size(768, 398);
            this.pgSzukaj.TabIndex = 0;
            this.pgSzukaj.Text = "Wyszukaj ucznia/uczniów";
            // 
            // tbLookedfor
            // 
            this.tbLookedfor.Location = new System.Drawing.Point(546, 92);
            this.tbLookedfor.Name = "tbLookedfor";
            this.tbLookedfor.Size = new System.Drawing.Size(142, 23);
            this.tbLookedfor.TabIndex = 8;
            // 
            // cmbHow
            // 
            this.cmbHow.FormattingEnabled = true;
            this.cmbHow.Items.AddRange(new object[] {
            "Zawiera",
            "Rozpoczyna się od"});
            this.cmbHow.Location = new System.Drawing.Point(321, 92);
            this.cmbHow.Name = "cmbHow";
            this.cmbHow.Size = new System.Drawing.Size(142, 23);
            this.cmbHow.TabIndex = 6;
            // 
            // cmbWhat
            // 
            this.cmbWhat.FormattingEnabled = true;
            this.cmbWhat.Items.AddRange(new object[] {
            "Nazwisko",
            "Imię",
            "Klasa"});
            this.cmbWhat.Location = new System.Drawing.Point(104, 92);
            this.cmbWhat.Name = "cmbWhat";
            this.cmbWhat.Size = new System.Drawing.Size(142, 23);
            this.cmbWhat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(99, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wczytaj kryteria wyszukiwania";
            // 
            // pgDodaj
            // 
            this.pgDodaj.BackColor = System.Drawing.SystemColors.Control;
            this.pgDodaj.Controls.Add(this.bttDodajUcznia);
            this.pgDodaj.Controls.Add(this.textBox2);
            this.pgDodaj.Controls.Add(this.label3);
            this.pgDodaj.Controls.Add(this.textBox1);
            this.pgDodaj.Controls.Add(this.label2);
            this.pgDodaj.Controls.Add(this.tbUser);
            this.pgDodaj.Controls.Add(this.label1);
            this.pgDodaj.Location = new System.Drawing.Point(4, 24);
            this.pgDodaj.Name = "pgDodaj";
            this.pgDodaj.Padding = new System.Windows.Forms.Padding(3);
            this.pgDodaj.Size = new System.Drawing.Size(768, 398);
            this.pgDodaj.TabIndex = 1;
            this.pgDodaj.Text = "Dodaj ucznia";
            // 
            // bttDodajUcznia
            // 
            this.bttDodajUcznia.Location = new System.Drawing.Point(471, 239);
            this.bttDodajUcznia.Name = "bttDodajUcznia";
            this.bttDodajUcznia.Size = new System.Drawing.Size(199, 29);
            this.bttDodajUcznia.TabIndex = 9;
            this.bttDodajUcznia.Text = "Dodaj";
            this.bttDodajUcznia.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(383, 23);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(118, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "klasa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(288, 42);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(383, 23);
            this.tbUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // bttSzukaj
            // 
            this.bttSzukaj.Location = new System.Drawing.Point(546, 130);
            this.bttSzukaj.Name = "bttSzukaj";
            this.bttSzukaj.Size = new System.Drawing.Size(142, 23);
            this.bttSzukaj.TabIndex = 9;
            this.bttSzukaj.Text = "Szukaj";
            this.bttSzukaj.UseVisualStyleBackColor = true;
            // 
            // edtOut
            // 
            this.edtOut.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtOut.Location = new System.Drawing.Point(34, 172);
            this.edtOut.Name = "edtOut";
            this.edtOut.Size = new System.Drawing.Size(702, 220);
            this.edtOut.TabIndex = 10;
            this.edtOut.Text = "";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcSekretariat);
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.tabcSekretariat.ResumeLayout(false);
            this.pgSzukaj.ResumeLayout(false);
            this.pgSzukaj.PerformLayout();
            this.pgDodaj.ResumeLayout(false);
            this.pgDodaj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabcSekretariat;
        private TabPage pgSzukaj;
        private ComboBox cmbHow;
        private ComboBox cmbWhat;
        private Label label4;
        private TabPage pgDodaj;
        private Button bttDodajUcznia;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox tbUser;
        private Label label1;
        private TextBox tbLookedfor;
        private RichTextBox edtOut;
        private Button bttSzukaj;
    }
}