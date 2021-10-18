using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public class Order : IOrder
    {
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
