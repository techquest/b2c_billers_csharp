using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
    public class TransactionInquiryRequest
    {
        public string paymentCode { set; get; }
        public string siteDomainName { set; get; }
        public string requestReference { set; get; }
        public string bankCbnCode { set; get; }
        public string hashedPIN { set; get; }
        public string deviceTerminalId { set; get; }
        public string cardPan { set; get; }

        public string customerId { set; get; }
        public string customerEmail { set; get; }
        public string customerMobile { set; get; }
        public string pageFlowValues { set; get; }
        public string terminalId { set; get; }
    }
}

