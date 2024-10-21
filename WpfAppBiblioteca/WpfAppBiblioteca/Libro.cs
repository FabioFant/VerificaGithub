using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBiblioteca
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private int _annoDiPubblicazione;
        private string _editore;
        private int _numeroDiPagine;

        public string Autore { get { return _autore; } }
        public string Titolo { get { return _titolo; } }
        public int AnnoDiPubblicazione { get { return _annoDiPubblicazione; } }
        public string Editore { get { return _editore; } }
        public int NumeroDiPagine { get { return _numeroDiPagine; } }

        public Libro(string autore, string titolo, int annoDiPubblicazione, string editore, int numeroDiPagine)
        {
            _autore = autore;
            _titolo = titolo;
            _annoDiPubblicazione = annoDiPubblicazione;
            _editore = editore;
            _numeroDiPagine = numeroDiPagine;
        }

        public override string ToString()
        {
            return $"{Autore} {Titolo} {AnnoDiPubblicazione} {Editore} {NumeroDiPagine}";
        }

        public string ReadingTime()
        {
            if (NumeroDiPagine < 100)
                return "1h";
            else if (NumeroDiPagine >= 100 && NumeroDiPagine <= 200)
                return "2h";
            else if (NumeroDiPagine >= 200)
                return "2h++";

            return "errore";
        }
    }
}
