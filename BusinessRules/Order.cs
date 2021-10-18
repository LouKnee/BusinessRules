using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public class Order : IOrder
    {
        public enum OrderType
        {
            ITEM_ORDER,
            BOOK_ORDER,
            MEMBERSHIP_ORDER
        }

        public IList<IOrderContent> Content
        {
            get;
            set;
        }

        public Order()
        {
            Content = new List<IOrderContent>();
            AddContent(new PackingSlip());
        }

        public void AddContent(IOrderContent item)
        {
            Content.Add(item);
        }

        public static IOrder OrderFactory(OrderType orderType)
        {
            IOrder order;

            switch (orderType)
            {
                case OrderType.ITEM_ORDER:
                    order = new Order();
                    break;
                case OrderType.BOOK_ORDER:
                    order = new BookOrder();
                    break;
                case OrderType.MEMBERSHIP_ORDER:
                    order = new MembershipOrder();
                    break;
                default:
                    throw new NotSupportedException();
            }
            return order;
        }
    }
}
