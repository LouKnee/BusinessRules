using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public class PackingSlip : IOrderContent
    {
        public string GetDetails()
        {
            return "Packing slip";
        }
    }
}
