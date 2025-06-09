using DesignPatternsDemo.Console.Patterns.Factory.Interfaces;

namespace DesignPatternsDemo.Console.Patterns.Factory.Implementations
{
    public class TitaniumCard : IBankCard
    {
        private const decimal WithdrawalLimit = 25000m;

        public string GetCardType()
        {
            return "Titanium Card";
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
            System.Console.WriteLine($"Titanium Card: Processing transaction of {amount:C}");
        }
    }
} 