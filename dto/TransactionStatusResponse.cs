using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
    public class TransactionStatusResponse
    {
        public Recharge recharge { set; get; }
        public StatusError[] errors { set; get; }
        public StatusError error { set; get; }
        public String amount { set; get; }
        public String currencyCode { set; get; }
        public String paymentDate { set; get; }
        public String paymentTypeCode { set; get; }
        public String serviceCode { set; get; }

        public String serviceName { set; get; }
        public String status { set; get; }
        public String responseCode { set; get; }
        public String transactionSet { set; get; }
        public String transactionResponseCode { set; get; }
        public String transactionRef { set; get; }
        public String serviceProviderId { set; get; }
    }
}
