using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogStudenti
{
    internal class Elev
    {
        private readonly string nume;
        private readonly string prenume;
        private int[] note;

        public Elev(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

        public double GetMedia()
        {
            if (this.note != null)
            {
                double medie = 0;


                foreach (int note in this.note)
                {
                    medie += note;
                }

               return (double)  medie / this.note.Length;
            }

            return 0;
        }


        public void SetNote(int numarNote)
        {
            note = new int[numarNote];

            Console.WriteLine();

            if (note != null)
            {
                for (int i = 0; i < numarNote; i++)
                {
                    Console.WriteLine($"Introuduce ti nota {i + 1} a elevului {this.nume} si {this.prenume} ");
                    this.note[i] = int.Parse(Console.ReadLine());
                }
            }

        }

        public void Tipareste()
        {
            double medie = GetMedia();

            if (note != null)
            {
                Console.WriteLine($"Notele sunt ");

                for (int i = 0; i < note.Length; i++)
                {
                    Console.WriteLine($"Notele sunt {note[i]}");
                }


                if (medie <= 0)

                    Console.WriteLine("\nElevul nu are media calculata ");

                else

                    Console.WriteLine("Elevul are media calculata ");
            }

            else
            {
                Console.WriteLine("Elevul nu are note !");
            }

        }


    }

}

