namespace programowanie_wizualne_lab3
{
    partial class dodaj
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnOK = new Button();
            btnAnuluj = new Button();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            numWiek = new TextBox();
            cmbStanowisko = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 91);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 142);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 193);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 2;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 243);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Stanowisko";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(214, 323);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 4;
            btnOK.Text = "Zatwierdź";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(403, 323);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(112, 34);
            btnAnuluj.TabIndex = 5;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(389, 91);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(184, 31);
            txtImie.TabIndex = 6;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(389, 136);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(184, 31);
            txtNazwisko.TabIndex = 7;
            txtNazwisko.TextChanged += textBox2_TextChanged;
            // 
            // numWiek
            // 
            numWiek.Location = new Point(389, 187);
            numWiek.Name = "numWiek";
            numWiek.Size = new Size(184, 31);
            numWiek.TabIndex = 8;
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.FormattingEnabled = true;
            cmbStanowisko.Location = new Point(389, 240);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(184, 33);
            cmbStanowisko.TabIndex = 9;
            // 
            // dodaj
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStanowisko);
            Controls.Add(numWiek);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(btnAnuluj);
            Controls.Add(btnOK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "dodaj";
            Text = "dodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnOK;
        private Button btnAnuluj;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox numWiek;
        private ComboBox cmbStanowisko;
    }
}