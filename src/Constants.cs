using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp
{
    public class Constants
    {
        public static string GET_CATEGORY_URL = "/api/v2/quickteller/categorys";
        public static string GET = "GET";
        public static string GET_BILLERS_URL = "/api/v2/quickteller/billers";
        public static string GET_CATEGORY_BILLERS_PAYMENTITEMS_PREFIX = "/api/v2/quickteller/billers/";
        public static string GET_CATEGORY_BILLERS_PAYMENTITEMS_SUFFIX = "/paymentitems";
        public static string GET_CATEGORY_BILLERS_PREFIX = "/api/v2/quickteller/categorys/";
        public static string GET_CATEGORY_BILLERS_SUFFIX = "/billers";
        public static string POST = "POST";
        public static string CUSTOMER_VALIDATION_RESOURCE_URL = "/api/v2/quickteller/customers/validations";
        public static string TRANSACTION_INQUIRY_RESOURCE_URL = "/api/v2/quickteller/transactions/inquirys";
        public static string SUCCESS = "90000";
        public static string PAYMENT_INQUIRY_RESOURCE_URL = "api/v2/quickteller/sendAdviceRequest";
    }
}
