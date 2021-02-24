using farkost.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farkost.farkostTyp
{
    public class Vattenfarkost : IFarkostModellVatten
    {
        public string FarkostTyp { get; set; }
        public string FarkostNamn { get; set; }
        public int MaxHastighet { get; set; }
        public string Märke { get; set; }
        public string ModelName { get; set; }

        public int ReleaseYear { get; set; }

        public int FarkostID { get; set; }

        public string längd { get; set; }
    }
}
