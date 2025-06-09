
using DesignPatternsDemo.Console.Patterns.Singleton;
using DesignPatternsDemo.Console.Patterns.Factory;
using DesignPatternsDemo.Console.Patterns.Adapter;
using DesignPatternsDemo.Console.Patterns.Adapter.Data;
using DesignPatternsDemo.Console.Patterns.Adapter.Entities;

namespace DesignPatternsDemo.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Design Patterns Demo");
            System.Console.WriteLine("===================");

            // Singleton Pattern Demo
            var first = Singleton.Instance;

            var second = Singleton.Instance;

            System.Console.WriteLine(ReferenceEquals(first, second)
                ? "Both instances are the same (Singleton works)."
                : "Instances are different (Singleton failed).");

            // Factory Pattern Demo
            System.Console.WriteLine("\n2. Factory Pattern Demo");
            System.Console.WriteLine("----------------------");
            var factory = new BankCardFactory();

            // Test Basic Card
            var basicCard = factory.CreateCard("basic");
            System.Console.WriteLine($"\nCreated card: {basicCard.GetCardType()}");
            System.Console.WriteLine($"Withdrawal limit: {basicCard.GetWithdrawalLimit():C}");
            basicCard.ProcessTransaction(500m);
            basicCard.ProcessTransaction(1500m); // Should fail

            // Test Gold Card
            var goldCard = factory.CreateCard("gold");
            System.Console.WriteLine($"\nCreated card: {goldCard.GetCardType()}");
            System.Console.WriteLine($"Withdrawal limit: {goldCard.GetWithdrawalLimit():C}");
            goldCard.ProcessTransaction(3000m);
            goldCard.ProcessTransaction(6000m); // Should fail

            // Test Platinum Card
            var platinumCard = factory.CreateCard("platinum");
            System.Console.WriteLine($"\nCreated card: {platinumCard.GetCardType()}");
            System.Console.WriteLine($"Withdrawal limit: {platinumCard.GetWithdrawalLimit():C}");
            platinumCard.ProcessTransaction(8000m);
            platinumCard.ProcessTransaction(12000m); // Should fail

            // Test Titanium Card
            var titaniumCard = factory.CreateCard("titanium");
            System.Console.WriteLine($"\nCreated card: {titaniumCard.GetCardType()}");
            System.Console.WriteLine($"Withdrawal limit: {titaniumCard.GetWithdrawalLimit():C}");
            titaniumCard.ProcessTransaction(20000m);
            titaniumCard.ProcessTransaction(30000m); // Should fail

            // Test Premium Card
            var premiumCard = factory.CreateCard("premium");
            System.Console.WriteLine($"\nCreated card: {premiumCard.GetCardType()}");
            System.Console.WriteLine($"Withdrawal limit: {premiumCard.GetWithdrawalLimit():C}");
            premiumCard.ProcessTransaction(40000m);
            premiumCard.ProcessTransaction(60000m); // Should fail

            // Adapter Pattern Demo
            IJsonParser<Email> parser = new XmlToJsonAdapter<Email>();
            Email email = parser.Parse(XmlData.XML_DATA);
            System.Console.WriteLine("Json Object: {0}", parser.ConvertToJson(email));

            System.Console.WriteLine("\nPress any key to exit...");
            System.Console.ReadKey();
        }
    }
}
