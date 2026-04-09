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
            buttonZapiszJson = new Button();
            buttonWczytajJson = new Button();
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
            // buttonZapiszJson
            // 
            buttonZapiszJson.Location = new Point(223, 349);
            buttonZapiszJson.Name = "buttonZapiszJson";
            buttonZapiszJson.Size = new Size(133, 34);
            buttonZapiszJson.TabIndex = 5;
            buttonZapiszJson.Text = "Zapisz JSON";
            buttonZapiszJson.UseVisualStyleBackColor = true;
            buttonZapiszJson.Click += buttonZapiszJson_Click;
            // 
            // buttonWczytajJson
            // 
            buttonWczytajJson.Location = new Point(411, 349);
            buttonWczytajJson.Name = "buttonWczytajJson";
            buttonWczytajJson.Size = new Size(142, 34);
            buttonWczytajJson.TabIndex = 6;
            buttonWczytajJson.Text = "Wczytaj JSON";
            buttonWczytajJson.UseVisualStyleBackColor = true;
            buttonWczytajJson.Click += buttonWczytajJson_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonWczytajJson);
            Controls.Add(buttonZapiszJson);
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
        private Button buttonZapiszJson;
        private Button buttonWczytajJson;
    }
}
