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

        [Test]
        public void OrderBookTest()
        {
            Account userAccount = new Account()
            {
                CurrentOrder = new Order(),
                OrderType = Account.OrderType.Book
            };
            userAccount.ProcessOrderPayment();
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Packing slip"));
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Royalty packing slip"));
        }

    }
}