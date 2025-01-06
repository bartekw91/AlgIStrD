using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListaDoZrob_175214
{
    public class NodeLZ // Node typu Zadanie, zawiera treść i datę ukończenia danego zadania
    {
        public string tekst;
        public DateOnly data;
        public NodeLZ next;
        public bool priority;
        public NodeLZ(string tekst, DateOnly koniec, bool priority)
        {
            this.tekst = tekst;
            this.data = koniec;
            this.next = null;
            this.priority = priority;
        }

        public override string ToString()
        {
            if (this.priority == false)
                return tekst + " | Ukończyć do: " + data.ToShortDateString();
            else
                return "[!]" + " " + tekst + " | Ukończyć do: " + data.ToShortDateString();
        }
    }
}
