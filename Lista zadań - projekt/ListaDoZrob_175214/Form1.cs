using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace ListaDoZrob_175214
{
    public partial class Form1 : Form
    {
        private NodeLZList ListaZadan;
        public Form1()
        {
            InitializeComponent();
            ListaZadan = new NodeLZList();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Wciœniêcie przycisku Dodaj
        {
            string opis = textBox2.Text;
            DateOnly data = DateOnly.FromDateTime(dateTimePicker1.Value);
            bool priorytet = checkBox1.Checked;
            if (!string.IsNullOrWhiteSpace(opis))
            {
                ListaZadan.Dodaj(opis, data, priorytet);
                checkBox1.Checked = false;
                textBox2.Clear();
                AktualizujListe();
                label8.Text = listBox1.Items.Count.ToString();
                label7.Text = ListaZadan.getCount();
            }
            else
                MessageBox.Show("Proszê wpisaæ tekst do dodania.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e) // Wciœniêcie przycisku Usuñ
        {
            bool przytrzymanoAlt = ModifierKeys.HasFlag(Keys.Alt); // Czy przytrzymano Alt?

            if (listBox1.SelectedItem != null && listBox1.Items.Count > 0 && ListaZadan.head != null)
            {
                ListaZadan.Usun(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                label8.Text = listBox1.Items.Count.ToString();
                label7.Text = ListaZadan.getCount();
            }
            else if (!przytrzymanoAlt && listBox1.Items.Count > 0 && ListaZadan.head != null) // Usuñ pierwszy wyraz
            {
                ListaZadan.Usun(listBox1.Items[0]);
                listBox1.Items.Remove(listBox1.Items[0]);
                label8.Text = listBox1.Items.Count.ToString();
                label7.Text = ListaZadan.getCount();
            }
            else if (przytrzymanoAlt && listBox1.Items.Count > 0 && ListaZadan.head != null)
            {
                int ostatniNaLiscie = listBox1.Items.Count - 1;

                ListaZadan.Usun(listBox1.Items[ostatniNaLiscie]);
                listBox1.Items.Remove(listBox1.Items[ostatniNaLiscie]);
                label8.Text = listBox1.Items.Count.ToString();
                label7.Text = ListaZadan.getCount();
            }
            else
            {
                string message = "Lista jest pusta!";
                MessageBox.Show(message, "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AktualizujListe() // Aktualizuje listbox'a
        {
            listBox1.Items.Clear();
            var nowalista = ListaZadan.ZdobadzListe();
            foreach (var node in nowalista)
            {
                listBox1.Items.Add(node);
            }
        }

        private void Znajdz(string tekst, string filtr, DateOnly data, string czypriorytet)
        {
            listBox1.Items.Clear();
            var wynik = SzukajListe.Szukaj(tekst, filtr, data, ListaZadan);

            foreach (var node in wynik)
            {
                if (czypriorytet.Contains("Bez Priorytetu") && node.priority == false)
                    listBox1.Items.Add(node);
                else if (czypriorytet.Contains("Z Priorytetem") && node.priority == true)
                    listBox1.Items.Add(node);
                else if (czypriorytet.Contains("Bez Zmian"))
                    listBox1.Items.Add(node);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) // Po wciœniêciu Eksport
        {
            if (listBox1.Items.Count > 0)
            {
                using (SaveFileDialog eksport = new SaveFileDialog())
                {
                    eksport.Filter = "Plik TXT(*.txt)|*.txt|Wszystkie Pliki(*.*)|*.*";
                    eksport.Title = "Eksportuj wyniki do...";
                    eksport.FileName = "Wynik";

                    if (eksport.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (StreamWriter zapis = new StreamWriter(eksport.OpenFile()))
                            {
                                zapis.WriteLine("Oto lista zadañ, które by³y wyœwietlone. [!] oznacza ¿e dane zadanie ma priorytet");
                                zapis.WriteLine();
                                foreach (var zad in listBox1.Items)
                                {
                                    zapis.WriteLine(zad.ToString());
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Podczas zapisywania wyœwietli³ siê b³¹d:" + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                string message = "Wyœwietlana lista jest pusta!";
                MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AktualizujListe();
        }

        private void button6_Click(object sender, EventArgs e) // Sortuj widok malej¹co wg daty
        {
            List<NodeLZ> danalista = listBox1.Items.Cast<NodeLZ>().ToList();

            if (checkBox2.Checked == true) // Sprawdzi czy zaznaczono opcjê ¿eby zadania priorytetowe zawsze by³y na górze
                danalista = danalista.OrderByDescending(x => x.priority).ThenByDescending(d => d.data).ToList();
            else
                danalista = danalista.OrderByDescending(d => d.data).ToList();

            listBox1.Items.Clear();
            foreach (var node in danalista)
            {
                listBox1.Items.Add(node);
            }
        }

        private void button5_Click(object sender, EventArgs e) // Sortuj widok rosn¹co wg daty
        {
            List<NodeLZ> danalista = listBox1.Items.Cast<NodeLZ>().ToList();

            if (checkBox2.Checked == true)// Sprawdzi czy zaznaczono opcjê ¿eby zadania priorytetowe zawsze by³y na górze
                danalista = danalista.OrderByDescending(x => x.priority).ThenBy(d => d.data).ToList();
            else
                danalista = danalista.OrderBy(d => d.data).ToList();

            listBox1.Items.Clear();
            foreach (var node in danalista)
            {
                listBox1.Items.Add(node);
            }
        }

        private void button8_Click(object sender, EventArgs e) // Przycisk Szukaj
        {
            string ptekstu = textBox1.Text;
            string filtrbox = comboBox1.Text;
            string czypriorytet = comboBox2.Text;
            DateOnly data = DateOnly.FromDateTime(dateTimePicker2.Value);

            if (!string.IsNullOrWhiteSpace(ptekstu))
            {
                Znajdz(ptekstu, filtrbox, data, czypriorytet);
                label8.Text = listBox1.Items.Count.ToString();
            }
            else
            {
                string message = "Proszê wpisaæ tekst do wyszukiwania.";
                MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }
    }
}
