using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public interface IOrder
    {
        IList<IOrderContent> Content
        {
            get;
            set;
        }
        void AddContent(IOrderContent item);

    }
}
