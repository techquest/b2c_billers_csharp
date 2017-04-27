using B2C_Billers_Csharp.dto;

namespace Sample
{
    public class GetBillers : BaseSample
    {

        static void Mainn(string[] args)
        {
            BillerResponse billers = billPayment.getBillers();
            if (billers != null)
            {
                Biller[] billerArray = billers.billers;

                Biller firstBiller = billerArray[0];

                string billerId = firstBiller.billerid;

                string billername = firstBiller.billername;

                
            }
        }

        
    }
}
