namespace ChainofResponsibility;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the string:");
        string input = Console.ReadLine();

        // Create the chain of handlers
        UserString upperHandler = new UpperString(input);
        UserString lowerHandler = new LowerString(input);
        UserString defaultHandler = new DefaultString(input);

        upperHandler.SetNext(lowerHandler);
        lowerHandler.SetNext(defaultHandler);

        upperHandler.Convert(); // Start processing
    }
}

abstract class UserString
{
    protected string s;
    protected UserString nextHandler;

    protected UserString(string s1)
    {
        s = s1;
    }

    public void SetNext(UserString next)
    {
        nextHandler = next;
    }

    public abstract void Convert();
}

class UpperString : UserString
{
    public UpperString(string s) : base(s) { }

    public override void Convert()
    {
        if (s.All(char.IsLower)) // Only process if string is lowercase
        {
            s = s.ToUpper();
            Console.WriteLine("UpperCase: " + s);
        }
        else if (nextHandler != null)
        {
            nextHandler.Convert(); // Pass to next handler
        }
    }
}

class LowerString : UserString
{
    public LowerString(string s) : base(s) { }

    public override void Convert()
    {
        if (s.All(char.IsUpper)) // Only process if string is uppercase
        {
            s = s.ToLower();
            Console.WriteLine("LowerCase: " + s);
        }
        else if (nextHandler != null)
        {
            nextHandler.Convert(); // Pass to next handler
        }
    }
}

class DefaultString : UserString
{
    public DefaultString(string s) : base(s) { }

    public override void Convert()
    {
        Console.WriteLine("Invalid input: " + s);
    }
}
