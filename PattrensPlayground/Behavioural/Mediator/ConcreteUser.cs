namespace Mediator;

public class ConcreteUser(IMGroupMediator mediator, string name) : User(mediator, name)
{
    public override void Receive(string message)
    {
        Console.WriteLine($"{this.Name}  Received Message {message}");
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{this.Name} Sending Message {message}");
        Mediator.SendMessage(message, this);
    }
}
