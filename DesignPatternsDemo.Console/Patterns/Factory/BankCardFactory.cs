using DesignPatternsDemo.Console.Patterns.Factory.Implementations;
using DesignPatternsDemo.Console.Patterns.Factory.Interfaces;

namespace DesignPatternsDemo.Console.Patterns.Factory
{
    public class BankCardFactory
    {
        public IBankCard CreateCard(string cardType)
        {
            return cardType.ToLower() switch
            {
                "basic" => new BasicCard(),
                "gold" => new GoldCard(),
                "platinum" => new PlatinumCard(),
                "titanium" => new TitaniumCard(),
                "premium" => new PremiumCard(),
                _ => throw new ArgumentException($"Card type {cardType} is not supported")
            };
        }
    }
} 