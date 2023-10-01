using System;
using System.Net.Cache;

using CatalogStudenti;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tastati numele  elevului=");
        string  nume = Console.ReadLine();
        Console.WriteLine("Tastati prenumele elevului =");
        string prenume = Console.ReadLine();    

        Elev elev = new Elev(nume,prenume);
      
        Console.WriteLine("Introduce ti numarul de note a elevului = ");
        int numarNote = int.Parse(Console.ReadLine());

        elev.SetNote(numarNote);

        elev.Tipareste();

      Console.WriteLine(elev.GetMedia());

        Console.WriteLine("Introduce ti numele clasei = ");

        string numeClasa = Console.ReadLine();

        Console.WriteLine("Tastati numele  elevului=");
        string nume1 = Console.ReadLine();
        Console.WriteLine("Tastati prenumele elevului =");
        string prenume1 = Console.ReadLine();

        Elev elev1 = new Elev(nume, prenume);

        Elev[] eleviClasei = { elev, elev1 };

        Catalog catolog = new Catalog(numeClasa ,eleviClasei);

        Console.WriteLine(catolog.GetPremiant());

        

    }
}