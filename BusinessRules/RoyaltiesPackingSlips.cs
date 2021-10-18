using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public class RoyaltiesPackingSlip : IOrderContent
    {
        public string GetDetails()
        {
            return "Royalties packing slip";
        }
    }
}
