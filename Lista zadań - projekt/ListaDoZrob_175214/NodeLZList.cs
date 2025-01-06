using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// LISTA JEDNOKIERUNKOWA
namespace ListaDoZrob_175214
{
    public class NodeLZList
    {
        public NodeLZ head;
        public int count = 0;
        public NodeLZList()
        {
            this.head = null;
        }

        public void Dodaj(string tekst, DateOnly koniec, bool priorytet) // Dodaje Node do listy
        {
            var nowy = new NodeLZ(tekst, koniec, priorytet);

            if (head == null)
            { 
                head = nowy;
                this.count++;
            }

            else
            {
                if (priorytet == true) // Jeżeli zadanie ma priorytet to zostanie on dodany jako pierwszy
                {
                    nowy.next = head;
                    head = nowy;
                    this.count++;
                }
                else // Jeżeli nie, to idzie na sam dół
                {
                    NodeLZ danyNode = head;
                    while (danyNode.next != null)
                    {
                        danyNode = danyNode.next;
                    }
                    danyNode.next = nowy;
                    this.count++;
                }
            }
        }
        public NodeLZ Usun(object tekst) // Usuwa dany Node z listy
        {
            if (head == tekst)
            {
                head = head.next;
                this.count--;
                return head;
            }

            NodeLZ danyNode = head;
            while(danyNode.next != null && danyNode.next != tekst)
                danyNode = danyNode.next;

            if (danyNode.next == null)
                return head;

            danyNode.next = danyNode.next.next;
            this.count--;

            return head;
        }

        public List<NodeLZ> ZdobadzListe() // Zamienia dany list żeby listBox mógł rozczytać
        {
            var wynik = new List<NodeLZ>();
            var danyNode = head;
            while(danyNode != null)
            {
                wynik.Add(danyNode);
                danyNode = danyNode.next;
            }
            return wynik;
        }
        public String getCount()
        {
            return this.count.ToString();
        }
    }
}
