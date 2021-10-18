using BusinessRules;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Packing slip"));
        }
    }
}