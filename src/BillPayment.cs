using B2C_Billers_Csharp.dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.src
{
   
    public class BillPayment
    {
        public static Interswitch.Interswitch interswitch;
        public BillPayment(string clientId, string clientSecret, string env = "SANDBOX") {

            interswitch = new Interswitch.Interswitch(clientId, clientSecret, env);
        }

        public TransactionInquiryResponse transactionInquiry(string paymentCode, string customerId)
        {
            TransactionInquiryRequest inquiryRequest = new TransactionInquiryRequest();
            inquiryRequest.paymentCode = paymentCode;
            inquiryRequest.customerId = customerId;

            Dictionary<string, string> response = interswitch.Send(Constants.TRANSACTION_INQUIRY_RESOURCE_URL, Constants.POST, inquiryRequest);
            String responseCode;
            response.TryGetValue(Interswitch.Interswitch.HTTP_CODE, out responseCode);
            String msg;
            response.TryGetValue(Interswitch.Interswitch.HTTP_RESPONSE, out msg);

            return JsonConvert.DeserializeObject<TransactionInquiryResponse>(msg);

        }

        public ValidateCustomerResponse validateCustomer(string paymentCode, string customerId)
        {
            ValidateCustomerRequest request = new ValidateCustomerRequest();
            Customer customer = new dto.Customer();
            customer.customerId = customerId;
            customer.paymentCode = paymentCode;
            Customer[] customerArray = new Customer[1];
            customerArray[0] = customer;

            request.customers = customerArray;


            Dictionary<string, string> response = interswitch.Send(Constants.CUSTOMER_VALIDATION_RESOURCE_URL, Constants.POST, request);
            String responseCode;
            response.TryGetValue(Interswitch.Interswitch.HTTP_CODE, out responseCode);
            String msg;
            response.TryGetValue(Interswitch.Interswitch.HTTP_RESPONSE, out msg);

            return JsonConvert.DeserializeObject<ValidateCustomerResponse>(msg);



        }

        public PaymentResponse makePayment(string amount, string customerId, string paymentCode)
        {

            Payment payment = new dto.Payment();
            payment.amount = amount;
            payment.customerId = customerId;
            payment.paymentCode = paymentCode;
            
            Dictionary<string, string> response = interswitch.Send(Constants.PAYMENT_INQUIRY_RESOURCE_URL, Constants.POST, payment);
            String responseCode;
            response.TryGetValue(Interswitch.Interswitch.HTTP_CODE, out responseCode);
            String msg;
            response.TryGetValue(Interswitch.Interswitch.HTTP_RESPONSE, out msg);

            return JsonConvert.DeserializeObject<PaymentResponse>(msg);
        }

        public CategoryResponse getCategorys()
        {
            Dictionary<string, string> extra = new Dictionary<string, string>();
            Dictionary<string, string> response = interswitch.Send(Constants.GET_CATEGORY_URL, Constants.GET);
            string responseCode;
            response.TryGetValue(Interswitch.Interswitch.HTTP_CODE, out responseCode);
            string msg;
            response.TryGetValue(Interswitch.Interswitch.HTTP_RESPONSE, out msg);

            return JsonConvert.DeserializeObject<CategoryResponse>(msg);
        }

        public PaymentItemResponse getBillerPaymentItems(string billerId)
        {
            Dictionary<string, string> extra = new Dictionary<string, string>();
            Dictionary<string, string> response = interswitch.Send(Constants.GET_CATEGORY_BILLERS_PAYMENTITEMS_PREFIX + billerId + Constants.GET_CATEGORY_BILLERS_PAYMENTITEMS_SUFFIX, Constants.GET);
            string responseCode;
            response.TryGetValue(Interswitch.Interswitch.HTTP_CODE, out responseCode);
                string msg;
            response.TryGetValue(Interswitch.Interswitch.HTTP_RESPONSE, out msg);

            return JsonConvert.DeserializeObject<PaymentItemResponse>(msg);
        }

        public BillerResponse getCategoryBillers(string id)
        {
            
            Dictionary<string, string> extra = new Dictionary<string, string>();
            Dictionary<string, string> response = interswitch.Send(Constants.GET_CATEGORY_BILLERS_PREFIX + id + Constants.GET_CATEGORY_BILLERS_SUFFIX, Constants.GET);
            string responseCode;
            response.TryGetValue(Interswitch.Interswitch.HTTP_CODE, out responseCode);
            string msg;
            response.TryGetValue(Interswitch.Interswitch.HTTP_RESPONSE, out msg);

            return JsonConvert.DeserializeObject<BillerResponse>(msg);

        }


        //method definitions go here
        public BillerResponse getBillers() {
            Dictionary<string, string> extra = new Dictionary<string, string>();
            Dictionary<string, string> response = interswitch.Send(Constants.GET_BILLERS_URL, Constants.GET);
            string responseCode;
            response.TryGetValue(Interswitch.Interswitch.HTTP_CODE, out responseCode);
            string msg;
            response.TryGetValue(Interswitch.Interswitch.HTTP_RESPONSE, out msg);

            return JsonConvert.DeserializeObject<BillerResponse>(msg);
            
        }
    }
}
