namespace BusinessRules
{
    public class BookOrder : Order
    {
        public BookOrder() :
            base()
        {
            AddContent(new RoyaltiesPackingSlip());
        }
    }
}