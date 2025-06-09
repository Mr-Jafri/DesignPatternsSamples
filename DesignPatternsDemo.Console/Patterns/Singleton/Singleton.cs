namespace DesignPatternsDemo.Console.Patterns.Singleton;

public class Singleton
{
    private static Singleton? _instance = null;
    private static readonly object _lock = new object();

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock) // Lock only when instance is null
                {
                    if (_instance == null) // Double check inside lock
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }

    // Private constructor to prevent instantiation
    private Singleton()
    {
        System.Console.WriteLine("Singleton instance created.");
    }
}