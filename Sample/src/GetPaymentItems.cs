using B2C_Billers_Csharp.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.src
{
    public class GetPaymentItems : BaseSample
    {
        static void Mainn(string[] args)
        {

            BillerResponse billers = billPayment.getBillers();
            if (billers != null)
            {
                Biller[] billerArray = billers.billers;

                Biller firstBiller = billerArray[2];

                String billerId = firstBiller.billerid;

                PaymentItemResponse resp = billPayment.getBillerPaymentItems(billerId);

                if (resp != null) {
                    PaymentItems[] paymentItemsArray = resp.paymentitems;

                    PaymentItems first = paymentItemsArray[0];

                    String id = first.paymentitemid;

                    String name = first.paymentitemname;

                    String amount = first.amount;
                }
            }

        }

    }
}
