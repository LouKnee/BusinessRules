namespace BusinessRules
{
    public class CommissionPayment : IOrderContent
    {
        public string GetDetails()
        {
            return "Commission payment";
        }
    }
}