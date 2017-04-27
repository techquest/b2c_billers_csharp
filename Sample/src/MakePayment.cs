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
        static void Mainn(string[] args)
        {
            string paymentCode = "40201";

            string customerId = "07030241757";

            string amount = "500"; // amount is in minor format.

            /**
            * The referencePrefix is a unique 4-sequence code for each Biller
            * You can get your own when you are set up as a merchant on our platform
            * It is not mandatory to have one
            * We strongly advice you get one because it will reduce the chances of reference collisions.
            * 
            * In the example below, we will be using "test" as out referencePrefix
            */
            String referencePrefix = "test"; //

            Random r = new Random();

            var x = r.Next(0, 1000000);

            String requestRef = x.ToString();

            requestRef = referencePrefix + requestRef;

            PaymentResponse response = billPayment.makePayment(amount, customerId, paymentCode, requestRef);

            if (response != null) {

                String transactionRef = response.transactionRef;

                
            }

        }
    }
}
