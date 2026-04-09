namespace programowanie_wizualne_lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonDodaj = new Button();
            buttonUsun = new Button();
            buttonZapiszCsv = new Button();
            buttonWczytajCsv = new Button();
            buttonZapiszXml = new Button();
            buttonWczytajXml = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(88, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(618, 225);
            dataGridView1.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(88, 309);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(112, 34);
            buttonDodaj.TabIndex = 1;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // buttonUsun
            // 
            buttonUsun.Location = new Point(244, 309);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(112, 34);
            buttonUsun.TabIndex = 2;
            buttonUsun.Text = "Usun";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // buttonZapiszCsv
            // 
            buttonZapiszCsv.Location = new Point(402, 309);
            buttonZapiszCsv.Name = "buttonZapiszCsv";
            buttonZapiszCsv.Size = new Size(151, 34);
            buttonZapiszCsv.TabIndex = 3;
            buttonZapiszCsv.Text = "Zapisz csv";
            buttonZapiszCsv.UseVisualStyleBackColor = true;
            buttonZapiszCsv.Click += buttonZapiszCsv_Click;
            // 
            // buttonWczytajCsv
            // 
            buttonWczytajCsv.Location = new Point(594, 309);
            buttonWczytajCsv.Name = "buttonWczytajCsv";
            buttonWczytajCsv.Size = new Size(112, 34);
            buttonWczytajCsv.TabIndex = 4;
            buttonWczytajCsv.Text = "Wczytaj csv";
            buttonWczytajCsv.UseVisualStyleBackColor = true;
            buttonWczytajCsv.Click += buttonWczytajCsv_Click;
            // 
            // buttonZapiszXml
            // 
            buttonZapiszXml.Location = new Point(88, 349);
            buttonZapiszXml.Name = "buttonZapiszXml";
            buttonZapiszXml.Size = new Size(112, 34);
            buttonZapiszXml.TabIndex = 5;
            buttonZapiszXml.Text = "Zapisz XML";
            buttonZapiszXml.UseVisualStyleBackColor = true;
            buttonZapiszXml.Click += buttonZapiszXml_Click;
            // 
            // buttonWczytajXml
            // 
            buttonWczytajXml.Location = new Point(244, 349);
            buttonWczytajXml.Name = "buttonWczytajXml";
            buttonWczytajXml.Size = new Size(126, 34);
            buttonWczytajXml.TabIndex = 6;
            buttonWczytajXml.Text = "Wczytaj XML";
            buttonWczytajXml.UseVisualStyleBackColor = true;
            buttonWczytajXml.Click += buttonWczytajXml_Click;
            // 
            // button1
            // 
            button1.Location = new Point(418, 349);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(594, 349);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonWczytajXml);
            Controls.Add(buttonZapiszXml);
            Controls.Add(buttonWczytajCsv);
            Controls.Add(buttonZapiszCsv);
            Controls.Add(buttonUsun);
            Controls.Add(buttonDodaj);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonDodaj;
        private Button buttonUsun;
        private Button buttonZapiszCsv;
        private Button buttonWczytajCsv;
        private Button buttonZapiszXml;
        private Button buttonWczytajXml;
        private Button button1;
        private Button button2;
    }
}
