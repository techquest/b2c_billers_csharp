using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_Billers_Csharp.dto
{
    public class Recharge
    {
        public string biller { set; get; }
        public string customerId1 { set; get; }
        public  string customerId2 { set; get; }
        public  string paymentTypeName { set; get; }
        public  string paymentTypeCode { set; get; }
        public string billerId { set; get; }
    }
}
