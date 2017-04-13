using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
    public class PaymentResponse
    {
        public string rechargePIN { set; get; }
        public string transferCode { set; get; }
        public string phcnTokenDetails { set; get; }
        public string recipientName { set; get; }
        public string miscData { set; get; }
        public string balance { set; get; }
        public string transactionRef { set; get; }
    }
}
