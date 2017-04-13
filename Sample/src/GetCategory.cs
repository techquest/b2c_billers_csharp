using B2C_Billers_Csharp.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.src
{
    public class GetCategory : BaseSample
    {
        static void Mainn(string[] args)
        {
            CategoryResponse response = billPayment.getCategorys();
            if (response != null) {

                Category[] categories = response.categorys;

                Category aCategory = categories[0];

                String categoryId = aCategory.categoryid;
                String categoryName = aCategory.categoryname;
                String categoryDesc = aCategory.categorydescription;
            }
        }
    }
}
