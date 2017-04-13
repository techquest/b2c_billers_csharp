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
        public String billerid { set; get; }
        public String isAmountFixed { set; get; }
        public String paymentitemid { set; get; }
        public String paymentitemname { set; get; }
        public String amount { set; get; }
        public String code { set; get; }
        public String currencyCode { set; get; }
        public String currencySymbol { set; get; }
        public String itemCurrencySymbol { set; get; }
        public String sortOrder { set; get; }
        public String pictureId { set; get; }
        public String paymentCode { set; get; }
        public String itemFee { set; get; }
    }
}
