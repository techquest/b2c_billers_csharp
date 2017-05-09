using B2C_Billers_Csharp.src;
using Interswitch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class BaseSample
    {
        /**
         *  Test clientId and clientSecret
         * 
         * */
        //public static String clientId = "IKIA2EFBE1EF63D1BBE2AF6E59100B98E1D3043F477A";
        //public static String clientSecret = "uAk0Amg6NQwQPcnb9BTJzxvMS6Vz22octQglQ1rfrMA=";

        //public static BillPayment billPayment = new BillPayment(clientId, clientSecret, Interswitch.Interswitch.DEV);


        public static String clientId = "IKIA6570778A3484D6F33BC7E4165ADCA6CF06B2860A";
        public static String clientSecret = "DXfUwpuIvMAKN84kv38uspqGOsStgFS0oZMjU7bPwpU=";

        public static BillPayment billPayment = new BillPayment(clientId, clientSecret, Interswitch.Interswitch.DEV);


    }
}
