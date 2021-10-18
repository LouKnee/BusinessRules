using System;

namespace BusinessRules
{
    public class Account
    {
        public IOrder CurrentOrder
        {
            get;
            set;
        }

        public void ProcessOrderPayment(int value)
        {
            CurrentOrder.AddContent(new PackingSlip());
        }
    }
}
