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

        public void ProcessOrderPayment(Order.OrderType orderType)
        {
            CurrentOrder = Order.OrderFactory(orderType);
        }
    }
}
