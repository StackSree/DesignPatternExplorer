namespace SingleInstance;

internal class Program
{
    static void Main(string[] args)
    {
        // Accessing the Singleton instance
        Singleton instance1 = Singleton.Instance;
        instance1.ShowMessage();

        // Accessing the Singleton instance again
        Singleton instance2 = Singleton.Instance;
        instance2.ShowMessage();

        // Checking if both instances are the same
        Console.WriteLine("Are both instances the same? " + (instance1 == instance2));

        Console.ReadKey();
    }
}

public class Singleton
{
    // Private static variable that holds the single instance of the class
    private static Singleton _instance;

    // Lock object for thread-safety
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation from outside the class
    private Singleton() { }

    // Public property to get the instance of the class
    public static Singleton Instance
    {
        get
        {
            // Check if the instance is null
            if (_instance == null)
            {
                // If null, lock to ensure thread safety during initialization
                lock (_lock)
                {
                    // Double-checking for the instance to ensure only one instance is created
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

    // A method to demonstrate the behavior of the Singleton class
    public void ShowMessage()
    {
        Console.WriteLine("Singleton Instance: " + this.GetHashCode());
    }
}
