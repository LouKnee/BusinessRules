using System;

namespace BusinessRules
{
    public class Account
    {
        public enum AccountMembership
        {
            NON_MEMBER,
            MEMBER,
            PRIME_MEMBER
        }

        public Account()
        {
            AccountType = AccountMembership.NON_MEMBER;
        }

        public AccountMembership AccountType;

        public IOrder CurrentOrder
        {
            get;
            set;
        }

        public void ProcessOrderPayment(Order.OrderType orderType, string title = null)
        {
            CurrentOrder = Order.OrderFactory(orderType, title);

            if (orderType == Order.OrderType.MEMBERSHIP_ORDER)
            {
                AccountType = AccountMembership.MEMBER;
            }
            else if (orderType == Order.OrderType.MEMBERSHIP_UPGRADE_ORDER)
            {
                AccountType = AccountMembership.PRIME_MEMBER;
            }
        }
    }
}
