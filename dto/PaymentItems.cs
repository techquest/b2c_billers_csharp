using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
   public class PaymentItems
    {
        public string categoryid { set; get; }
        public string billerid { set; get; }
        public string isAmountFixed { set; get; }
        public string paymentitemid { set; get; }
        public string paymentitemname { set; get; }
        public string amount { set; get; }
        public string code { set; get; }
        public string currencyCode { set; get; }
        public string currencySymbol { set; get; }
        public string itemCurrencySymbol { set; get; }
        public string sortOrder { set; get; }
        public string pictureId { set; get; }
        public string paymentCode { set; get; }
        public string itemFee { set; get; }
    }
}
