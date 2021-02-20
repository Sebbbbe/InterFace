using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farkost.Interface
{
   public interface IFarkostModell
    {
        string FarkostTyp { get; set; }
         string FarkostNamn { get; set; }
        string Märke { get; set; }
        string ModelName { get; set; }
        int MaxHastighet { get; set; }
       
      
        int ReleaseYear { get; set; }
    }
}
