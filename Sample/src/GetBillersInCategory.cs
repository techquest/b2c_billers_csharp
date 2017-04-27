using B2C_Billers_Csharp.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.src
{
    public class GetBillersInCategory:BaseSample
    {
        static void Mainn(string[] args)
        {

            CategoryResponse response = billPayment.getCategorys();
            if (response != null)
            {
                Category aCategory = response.categorys[0];

                String id = aCategory.categorydescription;

                BillerResponse billersResponse = billPayment.getCategoryBillers(id);

                if (billersResponse != null)
                {
                    Biller[] billerArray = billersResponse.billers;

                    Biller firstBiller = billerArray[0];

                    String billerId = firstBiller.billerid;

                    String billername = firstBiller.billername;

                }
                else
                {

                }
            }
        }
    }
}
