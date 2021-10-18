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
        public PackingSlip PackingSlip { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddContent(IOrderContent item)
        {
            Content.Add(item);
        }

        public void AddFirstAidVideo()
        {
            throw new System.NotImplementedException();
        }
    }
}