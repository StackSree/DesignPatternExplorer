namespace Mediator;

public abstract class User(IMGroupMediator mediator, string name)
{
    protected readonly IMGroupMediator Mediator = mediator;
    protected readonly string Name = name;

    public abstract void Send(string message);
    public abstract void Receive(string message);
}
