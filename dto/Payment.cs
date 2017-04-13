using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
    public class Payment
    {

        public string customerId { set; get; }
        public string amount { set; get; }
        public string customerEmail { set; get; }
        public string customerMobile { set; get; }
        public string transactionRef { set; get; }
        public string surcharge { set; get; }
        public string paymentCode { set; get; }
    }
}
