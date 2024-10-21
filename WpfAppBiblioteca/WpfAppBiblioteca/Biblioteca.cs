using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBiblioteca
{
    class _Libro
    {
        public string Autore { get; private set; }
        public string Titolo { get; private set; }
        public int AnnoDiPubblicazione;
        public string Editore { get; private set; }
        public int NumeroDiPagine { get; private set; }

        public _Libro(string autore, string titolo, int annoDiPubblicazione, string editore, int numeroDiPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoDiPubblicazione = annoDiPubblicazione;
            Editore = editore;
            NumeroDiPagine = numeroDiPagine;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Biblioteca
    {
        private string _nome;
        private string _apertura;
        private string _chiusura;
        private List<_Libro> _elenco;

        private string Nome { get { return _nome; } }
        private string Apertura { get { return _apertura; } }
        private string Chiusura { get { return _chiusura; } }

        public Biblioteca(string nome, string apertura, string chiusura)
        {
            _nome = nome;
            _apertura = apertura;
            _chiusura = chiusura;
            _elenco = new List<_Libro>();
        }

        public void AggiungiLibro(_Libro libro)
        {
            _elenco.Add(libro);
        }

        public _Libro TrovaLibroTitolo(string titolo)
        {
            for (int i = 0; i < _elenco.Count; i++)
            {
                if (_elenco[i].Titolo == titolo)
                    return _elenco[i];
            }

            return null;
        }

        public List<_Libro> TrovaLibriAutore(string autore)
        {
            List<_Libro> libri = new List<_Libro>();
            for (int i = 0; i < _elenco.Count; i++)
            {
                if (_elenco[i].Autore == autore)
                {
                    _Libro libro = new _Libro(_elenco[i].Autore, _elenco[i].Titolo, _elenco[i].AnnoDiPubblicazione, _elenco[i].Editore, _elenco[i].NumeroDiPagine);
                    libri.Add(libro);
                }
            }

            return libri;
        }

        public int NumeroLibri(string titolo)
        {
            return _elenco.Count;
        }
    }
}
