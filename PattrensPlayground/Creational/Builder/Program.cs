namespace Builder;

internal class Program
{
    static void Main(string[] args)
    {
        Builder.buildersingleton();
        Builder.converter();
    }
}

class UpperString : UserString
{
    public UpperString(String s)
        : base(s)
    { }

    public override void Convert()
    {
        s = s.ToUpper();
        Console.WriteLine(s);
    }
}

class LowerString : UserString
{
    public LowerString(String s)
        : base(s)
    { }

    public override void Convert()
    {
        s = s.ToLower();
        Console.WriteLine(s);
    }
}

abstract class UserString(string s1)
{
    protected string s = s1;

    public abstract void Convert();
}

class Builder
{

    private static Builder builder = null;

    // Private constructor to prevent instantiation from outside
    private Builder() { }

    public static Builder buildersingleton()
    {
        builder ??= new Builder();
        return builder;
    }

    public static void converter()
    {
        int choice = 1;
        String s;
        UserString u = null;

        do
        {
            Console.WriteLine("1:UpperCase 2:LowerCase");
            Console.WriteLine("enter the choice");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the string");
            s = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    u = new UpperString(s);
                    break;
                case 2:
                    u = new LowerString(s);
                    break;
                default:
                    return;
            }
            if (u != null)
                u.Convert();
            Console.WriteLine("enter 1 to continue");
            s = Console.ReadLine();
        } while (choice == 1);
    }
}
