using NUnit.Framework;

namespace BusinessRulesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OrderPhysicalProductTest()
        {
            Account userAccount = new Account()
            {
                CurrentOrder = new Order()
            };
            userAccount.ProcessOrderPayment(50);
            Assert.That(() => userAccount.CurrentOrder.Contents, Contains.Item(new PackingSlip()));
        }
    }
}