using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
    public class Customer
    {
        public string customerId { set; get; }
        public string paymentCode { set; get; }
        public string fullName { set; get; }
        public string responseCode { set; get; }
        public string responseDescription { set; get; }
    }
}
