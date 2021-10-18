using System.Collections.Generic;

namespace BusinessRules
{
    public class MembershipOrder : IOrder
    {
        public MembershipOrder(string message)
        {
            Content = new List<IOrderContent>();
            AddContent(new Email(message));
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