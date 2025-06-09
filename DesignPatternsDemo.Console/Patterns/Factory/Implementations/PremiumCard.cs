using DesignPatternsDemo.Console.Patterns.Factory.Interfaces;

namespace DesignPatternsDemo.Console.Patterns.Factory.Implementations
{
    public class PremiumCard : IBankCard
    {
        private const decimal WithdrawalLimit = 50000m;

        public string GetCardType()
        {
            return "Premium Card";
        }

        public decimal GetWithdrawalLimit()
        {
            return WithdrawalLimit;
        }

        public void ProcessTransaction(decimal amount)
        {
            if (amount > WithdrawalLimit)
            {
                System.Console.WriteLine($"Transaction failed: Amount {amount:C} exceeds withdrawal limit of {WithdrawalLimit:C}");
                return;
            }
            System.Console.WriteLine($"Premium Card: Processing transaction of {amount:C}");
        }
    }
} 