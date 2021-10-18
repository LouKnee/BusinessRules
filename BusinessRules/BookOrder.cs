namespace BusinessRules
{
    public class BookOrder : Order
    {
        public BookOrder(IOrderContent item1, IOrderContent item2) :
            base(item1)
        {
            AddContent(item2);
        }
    }
}