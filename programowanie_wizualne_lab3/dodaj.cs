using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programowanie_wizualne_lab3
{
    public partial class dodaj : Form
    {
        public string ImiePracownika { get; private set; }
        public string NazwiskoPracownika { get; private set; }
        public string WiekPracownika { get; private set; }
        public string StanowiskoPracownika { get; private set; }
        public dodaj()
        {
            InitializeComponent();

            cmbStanowisko.Items.Add("Dyrektor");
            cmbStanowisko.Items.Add("Asystent");
            cmbStanowisko.Items.Add("Sekretarka");
            cmbStanowisko.Items.Add("Stazysta");

            cmbStanowisko.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStanowisko.SelectedIndex = 0;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImie.Text) || string.IsNullOrWhiteSpace(txtNazwisko.Text))
            {
                MessageBox.Show("Uzupełnij imię i nazwisko.");
                return;
            }

            ImiePracownika = txtImie.Text.Trim();
            NazwiskoPracownika = txtNazwisko.Text.Trim();
            WiekPracownika = numWiek.Text.Trim();
            StanowiskoPracownika = cmbStanowisko.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
