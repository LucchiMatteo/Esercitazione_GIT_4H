using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Esercitazione_GIT_4H
{
    
    class Brano
    {
        string titolo, autore;
        int durata;

        //Costruttore
        public Brano(string titolo,string autore, int durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }

        //returna il titolo
        public string getTitolo()
        {
            return titolo;
        }

        //returna l'autore
        public string getAutore()
        { 
            return autore;
        }

        //returna la durata
        public int getDurata()
        {
            return durata;
        }

        //modifica il titolo
        public void setTitolo(string titolo)
        {
            this.titolo = titolo;

        }

        //modifica l'autore
        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        //returna la stringa con tutte le informazioni del brano
        public string toString()
        {
            return titolo + " " + autore + " " + durata;
        }

        //chiedi in input una durata e restituisce true se la durata del brano è inferiore alla durata presa in input
        public bool shortSong(int durata_2)
        {
            return (durata_2 > durata);
        }
    }
}
