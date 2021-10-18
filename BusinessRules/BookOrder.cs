namespace BusinessRules
{
    public class BookOrder : Order
    {
        public BookOrder(IOrderContent item1, IOrderContent item2, IOrderContent item3) :
            base(item1, item2)
        {
            AddContent(item3);
        }
    }
}