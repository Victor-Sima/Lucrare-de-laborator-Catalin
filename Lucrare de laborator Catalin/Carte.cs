using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucrare_de_laborator_Catalin
{
    internal class Carte
    {
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }

        public Carte(string titlu, string autor, string isbn)
        {
            Titlu = titlu;
            Autor = autor;
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"Titlu: {Titlu}, Autor: {Autor}, ISBN: {ISBN}";
        }
    }
}
