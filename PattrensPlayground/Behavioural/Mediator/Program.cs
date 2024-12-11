namespace Mediator;

internal static class Program
{
    private static void Main(string[] args)
    {
        var mediator = new ConcreteMGroupMediator();
        User ram = new ConcreteUser(mediator, "Ram");
        User dave = new ConcreteUser(mediator, "Dav");
        User smith = new ConcreteUser(mediator, "Smith");
        User rajesh = new ConcreteUser(mediator, "Rajesh");
        User sam = new ConcreteUser(mediator, "Sam");
        User pam = new ConcreteUser(mediator, "Pam");
        User anurag = new ConcreteUser(mediator, "Anurag");
        User john = new ConcreteUser(mediator, "John");
        mediator.RegisterUser(ram);
        mediator.RegisterUser(dave);
        mediator.RegisterUser(smith);
        mediator.RegisterUser(rajesh);
        mediator.RegisterUser(sam);
        mediator.RegisterUser(pam);
        mediator.RegisterUser(anurag);
        mediator.RegisterUser(john);
        dave.Send("This is behavioural mediator pattern example");
        Console.WriteLine();
        rajesh.Send("What is Design Patterns ? Please explain");
        Console.Read();
    }
}