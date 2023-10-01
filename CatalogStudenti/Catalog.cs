using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogStudenti
{
    internal class Catalog
    {
        private readonly string numeClasa;
        private readonly Elev[] elevClasei;// tip de date cu o anumita referinta 

        public Catalog(string numeClasa , Elev[] eleviClasei)
        {
                this.numeClasa = numeClasa;
                this.elevClasei = eleviClasei;
        }


        public Elev GetPremiant()
        {
            Elev premiant = null;
            double maxMedie = 0;

            foreach(Elev elev in this.elevClasei)
            {

                double medieElev = elev.GetMedia();

                if(maxMedie < medieElev)
                {
                    maxMedie = medieElev;
                    premiant = elev;
                }
                
            }

            return premiant;

        }

        public void Tipareste()
        {
            Console.WriteLine($"\n\n numele clasei este : {this.numeClasa}");

            foreach(Elev elev in this.elevClasei)
            {
                elev.Tipareste();
            }
        }
    }
}
