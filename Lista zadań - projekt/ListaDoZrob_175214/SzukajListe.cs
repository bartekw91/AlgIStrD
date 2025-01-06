using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDoZrob_175214
{
    public class SzukajListe
    {
        public static List<NodeLZ> Szukaj(string tekst, string filtr, DateOnly data, NodeLZList linkedlist)
        {
            var wynik = new List<NodeLZ>();
            var lista = linkedlist.ZdobadzListe();
            if (filtr.Contains("Brak"))
            {
                foreach (var node in lista)
                {
                    bool matresc = node.tekst.Contains(tekst, StringComparison.OrdinalIgnoreCase);
                    if (matresc)
                        wynik.Add(node);
                }
                return wynik;
            }
            else
            {
                foreach (var node in lista)
                {
                    bool matresc = node.tekst.Contains(tekst, StringComparison.OrdinalIgnoreCase);
                    if (string.IsNullOrWhiteSpace(tekst) || matresc)
                    {
                        if (filtr.Contains("Wcześniej niż") && node.data < data)
                            wynik.Add(node);
                        else if (filtr.Contains("Wcześniej do") && node.data <= data)
                            wynik.Add(node);
                        else if (filtr.Contains("Później za") && node.data > data)
                            wynik.Add(node);
                        else if (filtr.Contains("Później od") && node.data >= data)
                            wynik.Add(node);
                        else if (filtr.Contains("W dniu") && node.data == data)
                            wynik.Add(node);
                    }
                }

                return wynik;
            }
        }
    }
}
