using farkost.Fordon;
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

            List<IFarkostModel> farkost = new List<IFarkostModel>();
            //Bilar
            farkost.Add(new Bil { FarkostTyp = "Fordon", FarkostNamn = "Bil", Märke = "BMW", ModelName = "303", MaxHastighet = 90, ReleaseYear = 1933, HurMångaHjul = 4 });





        }
       
          
         
    }
}
