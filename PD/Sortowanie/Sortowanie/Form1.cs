namespace Sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SORTOWANIE B¥BELKOWE
        private void button1_Click(object sender, EventArgs e) // Sortowanie b¹belkowe
        {
            int[] array_b = { 3, 5, 6, 2, 1 };

            MessageBox.Show("Przed sortowaniem: " + TableToString(array_b));
            for (int i = 0; i < array_b.Length; i++)
            {
                for (int j = 0; j < array_b.Length - 1; j++)
                {
                    int temp = 0;
                    if (array_b[j] > array_b[j + 1])
                    {
                        temp = array_b[j + 1];
                        array_b[j + 1] = array_b[j];
                        array_b[j] = temp;
                    }
                }

            }
            MessageBox.Show("Po sortowaniu: " + TableToString(array_b));
        }
        private string TableToString(int[] array) // Funkcja t³umacz¹ca tablicê w string
        {
            string tablica = "";
            for (int i = 0; i < array.Length; i++)
            {
                tablica += array[i].ToString();
                if (i < array.Length - 1)
                {
                    tablica += " ";
                }
            }
            return tablica;
        }

        //SORTOWANIE PRZEZ STAWIANIE
        private void button2_Click(object sender, EventArgs e) // Sortowanie przez stawianie
        {
            int[] array_stw = { 56, 3, 1, 20, 33 };
            int temp = 0;
            MessageBox.Show("Przed sortowaniem: " + TableToString(array_stw));
            for (int i = 1; i < array_stw.Length; i++)
            {
                int j = i - 1;
                temp = array_stw[i];
                while (j >= 0 && array_stw[j] > temp)
                {
                    array_stw[j + 1] = array_stw[j];
                    j--;
                }
                array_stw[j + 1] = temp;

            }
            MessageBox.Show("Po sortowaniu: " + TableToString(array_stw));
        }

        //SORTOWANIE SZYBKIE
        private void button4_Click(object sender, EventArgs e)
        {
            int[] array_q = { 0, 12, 3, 5, 6, 10, 1, 2 };
            MessageBox.Show("Przed sortowaniem:" + TableToString(array_q));
            szybsort(array_q, 0, array_q.Length - 1);
            MessageBox.Show("Po sortowaniem:" + TableToString(array_q));
        }
        private void szybsort(int[] array, int p, int k)
        {
            if (p < k)
            {
                int punkt = dziel(array, p, k);
                szybsort(array, p, punkt - 1); // Rekurencja dla lewej czêœci tablicy
                szybsort(array, punkt + 1, k); // Rekurencja dla prawej czêœci tablicy
            }
        }
        private int dziel(int[] array, int p, int k) // Funkcja do dzielenia tablicy
        {
            int pkt = array[k];
            int i = p - 1;

            for (int j = p; j < k; j++)
            {
                if (array[j] <= pkt)
                {
                    i++;

                    int tempa = array[i];
                    array[i] = array[j];
                    array[j] = tempa;
                }
            }
            int temp = array[i + 1];
            array[i + 1] = array[k];
            array[k] = temp;
            return i + 1;
        }

        //SORTOWANIE PRZEZ SCALANIE
        private void button3_Click(object sender, EventArgs e)
        {
            int[] array_scale = { 3, 12, 33, 9, 1, 50, 78, 60 };
            MessageBox.Show("Przed sortowaniem:" + TableToString(array_scale));
            array_scale = scalanieSort(array_scale);
            MessageBox.Show("Po sortowaniu:" + TableToString(array_scale));

        }

        private int[] scalanieSort(int[] array)
        {
            if (array.Length <= 1) //Zwracamy tablicê je¿eli ma tylko jeden element
            {
                return array;
            }
            //Dzielimy tablicê na 2 czêœci
            int srodek = array.Length / 2;
            int[] polowa_l = array[0..srodek];
            int[] polowa_p = array[srodek..];
            //Sortujemy obie strony
            int[] sortowana_l = scalanieSort(polowa_l);
            int[] sortowana_p = scalanieSort(polowa_p);

            return polacz(sortowana_l, sortowana_p); //Zwracamy tablicê do sortowania
        }
        private int[] polacz(int[] lewy, int[] prawy)
        {
            List<int> wynik = new List<int>();
            int i = 0,j = 0;
            //Zaczynamy sortowanie
            while(i<lewy.Length && j < prawy.Length)
            {
                if (lewy[i] < prawy[j])
                {
                    wynik.Add(lewy[i]);
                    i++;
                }
                else
                {
                    wynik.Add(prawy[j]);
                    j++;
                }
            }
            wynik.AddRange(lewy[i..]); // Dodajemy elementy sortowane od lewej strony
            wynik.AddRange(prawy[j..]); // Dodajemy elementy sortowane od prawej strony
            return wynik.ToArray(); // Zwracamy tablicê po zmianie z listy
        }

        // SORTOWANIE PRZEZ ZLICZANIE
        private void button5_Click(object sender, EventArgs e)
        {
            int[] array_zl = {0, 3, 0, 1, 12, 33 };
            MessageBox.Show("Przed sortowaniem:" + TableToString(array_zl));
            int nw_nr = array_zl.Max(); // Wyszukaj najwiêksz¹ liczbê w tablicy
            int[] licz_t = new int[nw_nr + 1]; // Stwórz tablicê do obliczenia wyst¹pieñ danej liczby
            for(int i=0;i<nw_nr+1;i++) // Wstawiamy same zera do nowo utworzonej tablicy
            {
                licz_t[i] = 0;
            }
            //Liczymy ile jest wyst¹pieñ i zapisujemy do tablicy licz_t
            while(array_zl.Length > 0)
            {
                int liczba = array_zl.First();
                List<int> lista = new List<int>(array_zl);
                lista.RemoveAt(0);
                licz_t[liczba]++;
                array_zl = lista.ToArray();
            }
            //Koniec obliczenia wyst¹pieñ, czas na sortowanie
            for(int i=0;i < nw_nr+1;i++)
            {
                while (licz_t[i] > 0)
                {
                    List<int> lista = new List<int>(array_zl);
                    lista.Add(i);
                    licz_t[i]--;
                    array_zl = lista.ToArray();
                }
            }
            MessageBox.Show("Po sortowaniu:" + TableToString(array_zl));

        }
    }
}
