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
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.ITEM_ORDER);
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Packing slip"));
        }

        [Test]
        public void OrderBookTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.BOOK_ORDER);
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Packing slip"));
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Royalties packing slip"));
        }

        [Test]
        public void OrderMembershipTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.MEMBERSHIP_ORDER);
            Assert.That(userAccount.AccountType, Is.EqualTo(Account.AccountMembership.MEMBER));
        }

        public void OrderMembershipUpgradeTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.MEMBERSHIP_UPGRADE_ORDER);
            Assert.That(userAccount.AccountType, Is.EqualTo(Account.AccountMembership.PRIME_MEMBER));
        }

    }
}