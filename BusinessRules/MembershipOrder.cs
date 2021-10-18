using System.Collections.Generic;

namespace BusinessRules
{
    public class MembershipOrder : IOrder
    {
        public MembershipOrder(IOrderContent item)
        {
            Content = new List<IOrderContent>();
            AddContent(item);
        }

        public IList<IOrderContent> Content
        {
            get;
            set;
        }

        public void AddContent(IOrderContent item)
        {
            Content.Add(item);
        }
    }
}