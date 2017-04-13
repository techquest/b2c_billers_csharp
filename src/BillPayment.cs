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
