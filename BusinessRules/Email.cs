namespace BusinessRules
{
    internal class Email : IOrderContent
    {
        private string _message;

        public Email(string message)
        {
            _message = message;
        }

        public string GetDetails()
        {
            return _message;
        }
    }
}