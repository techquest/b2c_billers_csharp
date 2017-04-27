using B2C_Billers_Csharp;
using B2C_Billers_Csharp.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.src
{
    public class TransactionStatus : BaseSample
    {
        static void Main(string[] args) {

            /**
             * Purpose: To get the status of a transaction after making a payment.
             * 
             * 1. Make Payment with a unique requestReference
             * 2. Query for the transaction
             */


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

            try
            {
                //STEP 1 : Make payment
                PaymentResponse paymentResponse = billPayment.makePayment(amount, customerId, paymentCode, requestRef);

                //STEP 2 : Query Transaction Status
                TransactionStatusResponse transactionStatus =  billPayment.getTransactionStatus(requestRef);
                if (transactionStatus != null ) {

                    if (transactionStatus.responseCode != null && transactionStatus.responseCode.Equals(Constants.SUCCESS)) {

                        String status = transactionStatus.status; // COMPLETE, INPROGRESS

                        Console.WriteLine("Status: "+status);

                    }
                else{

                        String errorMessage = transactionStatus.error.message;
                        String errorCode = transactionStatus.error.code;

                        Console.WriteLine(errorMessage + " : " + errorCode);

                    }

                }

            }
            catch (Exception e) {
                throw e;
            }

        }
    }
}
