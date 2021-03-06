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

        [Test]
        public void OrderMembershipUpgradeTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.MEMBERSHIP_UPGRADE_ORDER);
            Assert.That(userAccount.AccountType, Is.EqualTo(Account.AccountMembership.PRIME_MEMBER));
        }

        [Test]
        public void OrderMembershipEmailTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.MEMBERSHIP_ORDER);
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Emailed the user about account activation"));
        }

        [Test]
        public void OrderMembershipUpgradeEmailTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.MEMBERSHIP_UPGRADE_ORDER);
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Emailed the user about account upgrade"));
        }

        [Test]
        public void OrderVideoTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.VIDEO_ORDER);
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Packing slip"));
        }

        [Test]
        public void OrderLearningToSkiTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.VIDEO_ORDER, "Learning To Ski");
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Packing slip"));
            Assert.That(((Order)userAccount.CurrentOrder).PackingSlip.FirstAidVideoAttched, Is.True);
        }

        [Test]
        public void ProductCommisionPaymentTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.ITEM_ORDER);
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Commission payment"));
        }

        [Test]
        public void BookCommisionPaymentTest()
        {
            Account userAccount = new Account();
            userAccount.ProcessOrderPayment(Order.OrderType.BOOK_ORDER);
            Assert.That(userAccount.CurrentOrder.Content.Any(c => c.GetDetails() == "Commission payment"));
        }
    }
}