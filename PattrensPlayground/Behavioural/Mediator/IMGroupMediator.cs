namespace Mediator;

public interface IMGroupMediator
{
    void SendMessage(string msg, User user);
    void RegisterUser(User user);
}
