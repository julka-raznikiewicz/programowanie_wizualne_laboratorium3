using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
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

        private void ZapisDoJson(string filePath)
        {
            List<Osoba> lista = PobierzOsobyZTabeli();

            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, json);
        }

        private void OdczytZJson(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik JSON nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string json = File.ReadAllText(filePath);
            List<Osoba> lista = JsonSerializer.Deserialize<List<Osoba>>(json);

            WczytajOsobyDoTabeli(lista);
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

        private void ZapisDoPliku(string filePath)
        {
            string csvContent = "ID,Imie,Nazwisko,Wiek,Stanowisko" + Environment.NewLine;

            foreach (DataRow row in tabelaPracownikow.Rows)
            {
                csvContent += string.Join(",", row.ItemArray) + Environment.NewLine;
            }

            File.WriteAllText(filePath, csvContent);
        }

        private void buttonZapiszCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacjê zapisu pliku CSV";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ZapisDoPliku(saveFileDialog1.FileName);
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

            tabelaPracownikow.Rows.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');

                if (values.Length == 5)
                {
                    tabelaPracownikow.Rows.Add(
                        int.Parse(values[0]),
                        values[1],
                        values[2],
                        int.Parse(values[3]),
                        values[4]
                    );
                }
            }

            if (tabelaPracownikow.Rows.Count > 0)
            {
                nextId = tabelaPracownikow.AsEnumerable()
                    .Max(r => r.Field<int>("ID")) + 1;
            }
            else
            {
                nextId = 1;
            }
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

        private void buttonZapiszJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Wybierz lokalizacjê zapisu pliku JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ZapisDoJson(saveFileDialog.FileName);
                MessageBox.Show("Dane zapisano do JSON.");
            }
        }

        private void buttonWczytajJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Wybierz plik JSON do wczytania";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OdczytZJson(openFileDialog.FileName);
                MessageBox.Show("Dane wczytano z JSON.");
            }
        }
    }
}
