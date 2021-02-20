using farkost.farkostTyp;

using farkost.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farkost
{
  public  class Program
    {
        static void Main(string[] args)
        {

            List<IFarkostModell> farkost = new List<IFarkostModell>();
            //Bilar
            farkost.Add(new Bil { FarkostTyp = "Fordon", FarkostNamn = "Bil", Märke = "BMW", ModelName = "303", MaxHastighet = 90, ReleaseYear = 1933, hjul = 4 });
            farkost.Add(new Cykel { FarkostTyp = "Fordon" , FarkostNamn ="Cykel" , Märke="crescent", ModelName= "Kraft k50 29" , ReleaseYear=2010 , hjul = 2});
            farkost.Add(new Flygplan { FarkostTyp ="Luftfarkost" , FarkostNamn ="Flygplan" , Märke = "Lufthansa" , ModelName = "Airbus A380" , ReleaseYear = 2005, AntalSittPlatser = 300  });
            farkost.Add(new Helikopter { FarkostTyp = "Luftfarkost" , FarkostNamn = "Helikopter" , Märke="Robinson" , ModelName="R-44 Raven II", MaxHastighet=240,AntalSittPlatser = 4 , ReleaseYear = 1991 });
            farkost.Add(new Rymdskepp {FarkostTyp = "Rymdfarkost" , FarkostNamn = "Rymdskepp", Märke ="SpaceX", ModelName= "Crew Dragon Endeavour", MaxHastighet=10000 , Kostnad=2000000000 });
            farkost.Add(new Båt {FarkostTyp="Vattenfarkost" , FarkostNamn="Båt" , Märke="Buster" , ModelName="Magnum" , MaxHastighet=47 , längd = "2", ReleaseYear = 1990 });
            farkost.Add(new Svävare {FarkostTyp="Vattenfarkost", FarkostNamn="Svävare" , Märke = "	N. Stavsudda Handel" , ModelName = "Rescue Virginia Wij",längd = "5" , MaxHastighet = 34 , ReleaseYear = 2008  });







            }
       
          
         
    }
}
