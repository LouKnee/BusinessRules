using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public class Order : IOrder
    {
        public const string BookOrderType = "BOOK";

        public IList<IOrderContent> Content
        {
            get;
            set;
        }

        public Order()
        {
            Content = new List<IOrderContent>();
        }

        public void AddContent(IOrderContent item)
        {
            Content.Add(item);
        }
    }
}
