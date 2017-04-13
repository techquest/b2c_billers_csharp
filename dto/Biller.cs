using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
    public class Biller
    {
        public string categoryname {set;get;}
        public string categorydescription { set; get; }
        public string billerid { set; get; }
        public string shortName { set; get; }
        public string currencyCode { set; get; }
        public string surcharge { set; get; }
        public string billername { set; get; }
        public string categorysid { set; get; }
    }
}
