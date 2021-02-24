using farkost.farkostTyp;

using farkost.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace farkost
{
  public  class Program
    {
        static void Main(string[] args)
        {
            var inputValue = 0;
            int count = 1;

          

            List<IFarkostModell> farkost = new List<IFarkostModell>();

            farkost.Add(new Bil { FarkostTyp = "Fordon", FarkostID = 1, FarkostNamn = "Bil", Märke = "BMW", ModelName = "303", MaxHastighet = 90, ReleaseYear = 1933, hjul = 4 });
            farkost.Add(new Cykel { FarkostTyp = "Fordon", FarkostID = 1, FarkostNamn = "Cykel", Märke = "crescent", ModelName = "Kraft k50 29", ReleaseYear = 2010, hjul = 2 });
            farkost.Add(new Flygplan { FarkostTyp = "Luftfarkost", FarkostID = 2, FarkostNamn = "Flygplan", Märke = "Lufthansa", ModelName = "Airbus A380", ReleaseYear = 2005, AntalSittPlatser = 300 });
            farkost.Add(new Helikopter { FarkostTyp = "Luftfarkost", FarkostID = 2, FarkostNamn = "Helikopter", Märke = "Robinson", ModelName = "R-44 Raven II", MaxHastighet = 240, AntalSittPlatser = 4, ReleaseYear = 1991 });
            farkost.Add(new Båt { FarkostTyp = "Vattenfarkost", FarkostID = 3, FarkostNamn = "Båt", Märke = "Buster", ModelName = "Magnum", MaxHastighet = 47, längd = "2", ReleaseYear = 1990 });
            farkost.Add(new Svävare { FarkostTyp = "Vattenfarkost", FarkostID = 3, FarkostNamn = "Svävare", Märke = "	N. Stavsudda Handel", ModelName = "Rescue Virginia Wij", längd = "5", MaxHastighet = 34, ReleaseYear = 2008 });
            farkost.Add(new Rymdskepp { FarkostTyp = "Rymdfarkost", FarkostID = 4, FarkostNamn = "Rymdskepp", Märke = "SpaceX", ModelName = "Crew Dragon Endeavour", MaxHastighet = 10000, Kostnad = 2000000000 });


            var farkostTypLista = farkost.Select(x => x.FarkostTyp);
            var farkostTypLista2 = farkost.Where(x => x.FarkostTyp == "Fordon");
            var unikaFarkostTyper = farkostTypLista.Distinct().ToList();

            Console.WriteLine("Vilka farkosttyp vill du veta mer om");

            foreach (var farkostTyp in unikaFarkostTyper)
            {
                Console.WriteLine($"{count}. {farkostTyp}");
                count++;
            }



            inputValue = int.Parse(Console.ReadLine());



            
     


            foreach (var item in farkost)
            {
               
               
            }

        }


   



    }
}
