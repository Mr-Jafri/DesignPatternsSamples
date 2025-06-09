namespace DesignPatternsDemo.Console.Patterns.Factory.Interfaces
{
    public interface IBankCard
    {
        string GetCardType();
        decimal GetWithdrawalLimit();
        void ProcessTransaction(decimal amount);
    }
} 