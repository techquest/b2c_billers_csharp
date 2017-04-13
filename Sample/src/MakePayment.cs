using B2C_Billers_Csharp.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.src
{
    public class MakePayment : BaseSample
    {
        static void Main(string[] args)
        {
            string paymentCode = "40201";

            string customerId = "07030241757";

            string amount = "500"; // amount is in minor format.

            PaymentResponse response = billPayment.makePayment(amount, customerId, paymentCode);

            if (response != null) {

                String transactionRef = response.transactionRef;

                
            }

        }
    }
}
