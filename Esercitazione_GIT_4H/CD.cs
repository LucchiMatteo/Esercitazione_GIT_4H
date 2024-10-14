using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_GIT_4H
{
    internal class CD
    {
        private string titolo, autore;
        private List<Brano> brani = new List<Brano>();

        public CD(string titolo, string autore, List<Brano> brani)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.brani = brani;
        }

        public string getTitolo() { return titolo; }
        public string getAutore() { return autore; }
        public void setTitolo(string value) { titolo = value; }
        public void setAutore(string value) { autore = value; }


        public string toString(List<Brano> brani)
        {
            string listaDiBrani = "";
            for (int i = 0; i < brani.Count; i++)
            {
                listaDiBrani += " " + brani[i].getTitolo();
            }
            return listaDiBrani;
        }

        public int Durata(List<Brano> brani)
        {
            int durata = 0;
            for (int i = 0; i < brani.Count; i++)
            {
                durata += brani[i].getDurata();
            }
            return durata;
        }
    }
}
