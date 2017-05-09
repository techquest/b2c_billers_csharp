using B2C_Billers_Csharp.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.src
{
    public class MakeTransactionInquiry : BaseSample
    {
        static void Mainn(string[] args)
        {
            string paymentCode = "90101"; //paymentCode for test="40201", paymentCode for sandbox=90101

            string customerId = "07030241757";

            TransactionInquiryResponse response = billPayment.transactionInquiry(paymentCode, customerId);

            if (response != null) {
                string transactionRefernce = response.TransactionRef;
            }
        }
    }
}
