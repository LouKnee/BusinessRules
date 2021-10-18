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
            MEMBERSHIP_ORDER,
            MEMBERSHIP_UPGRADE_ORDER,
            VIDEO_ORDER
        }

        public IList<IOrderContent> Content
        {
            get;
            set;
        }

        public Order(IOrderContent item)
        {
            Content = new List<IOrderContent>();
            AddContent(item);
        }

        public void AddContent(IOrderContent item)
        {
            Content.Add(item);
        }

        public PackingSlip PackingSlip
        {
            get => (PackingSlip)Content[0];
            set => throw new NotImplementedException();
        }

        public static IOrder OrderFactory(OrderType orderType, string title = null)
        {
            IOrder order;

            switch (orderType)
            {
                case OrderType.ITEM_ORDER:
                    order = new Order(new PackingSlip());
                    break;
                case OrderType.BOOK_ORDER:
                    order = new BookOrder(new PackingSlip(), new RoyaltiesPackingSlip());
                    break;
                case OrderType.MEMBERSHIP_ORDER:
                    order = new MembershipOrder(new Email("Emailed the user about account activation"));
                    break;
                case OrderType.MEMBERSHIP_UPGRADE_ORDER:
                    order = new MembershipOrder(new Email("Emailed the user about account upgrade"));
                    break;
                case OrderType.VIDEO_ORDER:
                    order = new VideoOrder(new PackingSlip(), title);
                    break;
                default:
                    throw new NotSupportedException();
            }
            return order;
        }

        public void AddFirstAidVideo()
        {
            PackingSlip.FirstAidVideoAttched = true;
        }
    }
}
