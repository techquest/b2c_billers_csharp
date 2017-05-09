using B2C_Billers_Csharp.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.src
{
    public class AllInOneSample : BaseSample
    {
        static void Main(string[] args) {
            string customerId = "07030241757";// (mandatory) customerId

            string amount = "500"; // (mandatory) amount is in minor.

            string paymentCode = "40201";

            try
            {

                // 1. Get All Categorys
                CategoryResponse categoryResponse = billPayment.getCategorys();



                String categoryId = categoryResponse != null ? categoryResponse.categorys[0].categoryid : null;

                if (categoryId == null) throw new Exception("CateogryId cannot be null");

                
                // 2. Get Billers given a categoryId
                BillerResponse billersResponse = billPayment.getCategoryBillers(categoryId);

                String billerId = billersResponse != null ? billersResponse.billers[0].billerid : null;

                if (billerId == null) throw new Exception("Biller Id cannot be null");
                
                // 3. Get All PaymentItems for billerId
                PaymentItemResponse paymentItemResponse = billPayment.getBillerPaymentItems(billerId);

                String paymentItemCode = paymentItemResponse != null ? paymentItemResponse.paymentitems[0].paymentCode : null;

                if (paymentItemCode == null) throw new Exception("Payment Item Response cannot be is null");


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


                // 4. Validate the customer
                ValidateCustomerResponse validateCustomer = billPayment.validateCustomer(paymentCode, customerId);

                if (validateCustomer == null){

                    throw new Exception("Invalid CustomerId ");
                }

                var requestReference = "test" + requestRef;

                // 5. Make a payment to a paymentcode
                PaymentResponse paymentResponse = billPayment.makePayment(amount, customerId, paymentCode, requestReference);




                //6. Query the status of a transaction
                TransactionStatusResponse transactionStatus = billPayment.getTransactionStatus(requestReference);

                String status = transactionStatus.status;

                Console.WriteLine("status: " + status);
            }
            catch (Exception ex)
            {

                //
            }
        }
    }
}
