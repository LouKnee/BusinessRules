using System.Collections.Generic;

namespace BusinessRules
{
    public class MembershipOrder : IOrder
    {
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