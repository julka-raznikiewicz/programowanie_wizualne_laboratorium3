using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace programowanie_wizualne_lab3
{
    public partial class Form1 : Form
    {
        private DataTable tabelaPracownikow = new DataTable();
        private int nextId = 1;
        public Form1()
        {
            InitializeComponent();
            InicjalizujTabele();
        }
        private void InicjalizujTabele()
        {
            tabelaPracownikow.Columns.Add("ID", typeof(int));
            tabelaPracownikow.Columns.Add("Imie", typeof(string));
            tabelaPracownikow.Columns.Add("Nazwisko", typeof(string));
            tabelaPracownikow.Columns.Add("Wiek", typeof(int));
            tabelaPracownikow.Columns.Add("Stanowisko", typeof(string));

            dataGridView1.DataSource = tabelaPracownikow;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            dodaj form = new dodaj();

            if (form.ShowDialog() == DialogResult.OK)
            {
                tabelaPracownikow.Rows.Add(
                    nextId,
                    form.ImiePracownika,
                    form.NazwiskoPracownika,
                    form.WiekPracownika,
                    form.StanowiskoPracownika
                );

                nextId++;
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                tabelaPracownikow.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Zaznacz wiersz do usuniêcia.");
            }
        }

        private void ZapisDoPliku(DataGridView dataGridView1, string filePath)
        {
            string csvContent = "Imie,Nazwisko,Wiek" + Environment.NewLine;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (!row.IsNewRow)
                {
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            File.WriteAllText(filePath, csvContent);
        }

        private void buttonZapiszCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacjê zapisu pliku CSV";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                ZapisDoPliku(dataGridView1, saveFileDialog1.FileName);
            }

        }

        private void odczyt(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines(filePath);

            DataTable dataTable = new DataTable();

            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                dataTable.Rows.Add(values);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void buttonWczytajCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                odczyt(openFileDialog1.FileName);
            }

        }
    }
}
