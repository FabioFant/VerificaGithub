using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBiblioteca
{
    class Biblioteca
    {
        private string _nome;
        private string _apertura;
        private string _chiusura;
        private List<Libro> _elenco;

        public string Nome { get { return _nome; } }
        public string Apertura { get { return _apertura; } }
        public string Chiusura { get { return _chiusura; } }

        public Biblioteca(string nome, string apertura, string chiusura)
        {
            _nome = nome;
            _apertura = apertura;
            _chiusura = chiusura;
            _elenco = new List<Libro>();
        }

        public void AggiungiLibro(Libro libro)
        {
            _elenco.Add(libro);
        }

        public Libro TrovaLibroTitolo(string titolo)
        {
            for (int i = 0; i < _elenco.Count; i++)
            {
                if (_elenco[i].Titolo == titolo)
                    return _elenco[i];
            }

            return null;
        }

        public List<Libro> TrovaLibriAutore(string autore)
        {
            List<Libro> libri = new List<Libro>();
            for (int i = 0; i < _elenco.Count; i++)
            {
                if (_elenco[i].Autore == autore)
                {
                    Libro libro = new Libro(_elenco[i].Autore, _elenco[i].Titolo, _elenco[i].AnnoDiPubblicazione, _elenco[i].Editore, _elenco[i].NumeroDiPagine);
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
