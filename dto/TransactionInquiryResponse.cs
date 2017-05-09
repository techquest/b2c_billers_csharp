using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
    public class TransactionInquiryResponse
    {

        public string Biller { set; get; }
        public string CustomerId { set; get; }
        public string CustomerName { set; get; }
        public string PaymentItem { set; get; }
        public string Narration { set; get; }
        public string Amount { set; get; }
        public string IsAmountFixed { set; get; }
        public string CollectionsAccountNumber { set; get; }
        public string CollectionsAccountType { set; get; }
        public string Surcharge { set; get; }
        public string ResponseCode { set; get; }
        public string ShortTransactionRef { set; get; }
        public string TransactionRef { set; get; }
    }
}
