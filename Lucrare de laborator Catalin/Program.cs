using System;
using System.Collections.Generic;

namespace Lucrare_de_laborator_Catalin
{
    internal class Librari{

        private static List<Carte> carti = new();
        class Biblioteca
        {

            public void AdaugaCarte()
            {
                Console.Write("Cate carti doresti sa adaugi: ");
                int numarCarti = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numarCarti; i++)
                {
                    Console.Write("Introduceti titlul carti: ");
                    string? titlu = Console.ReadLine();

                    Console.Write("Introduceti autorul carti: ");
                    string? autorul = Console.ReadLine();

                    Console.Write("Introduceti ISBN al carti: ");
                    string? isbn = Console.ReadLine();
                    carti.Add(new Carte(titlu, autorul, isbn));
                    Console.WriteLine("\n");

                }


            }
            public void EliminaCarte()
            {
                Console.Write("A cata carte doresti sa ii stergi: ");

                if (int.TryParse(Console.ReadLine(), out int modificare))
                {
                    if (modificare >= 1 && modificare <= carti.Count)
                    {
                        carti.RemoveAt(modificare - 1);
                        Console.WriteLine("\n A fost sters");
                    }
                }
            }

            public void AfiseazaToateCartile()
            {
                Console.WriteLine("Cartile din bibliotecă:");
                foreach (var carte in carti)
                {
                    Console.WriteLine(carte);
                }
            }
        }
        class Program
        {
            static void Main()
            {
                while (true)
                {
                    Console.WriteLine(" ==== Meniu ====  ");
                    Console.WriteLine("1. Aduga carti");
                    Console.WriteLine("2. Afisarea Cartilor");
                    Console.WriteLine("3. Sterge cartilor");
                    Console.WriteLine("4. Iesire din banca");

                    int numer = Convert.ToInt32(Console.ReadLine());
                    switch (numer)
                    {
                        case 1:
                            Biblioteca AddBok = new Biblioteca();
                            AddBok.AdaugaCarte();
                            break;

                        case 2:
                            Biblioteca afisareCarti = new Biblioteca();
                            afisareCarti.AfiseazaToateCartile();
                            break;

                        case 3:
                            Biblioteca eliminare = new Biblioteca();
                            eliminare.EliminaCarte();
                            break;
                    }
                    if (numer == 4) break;
                    Console.WriteLine("\n");
                }
            }
        }
    }
}