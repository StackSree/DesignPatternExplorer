namespace Mediator;

public class ConcreteMGroupMediator : IMGroupMediator
{
    private readonly List<User> _usersList = [];

    public void RegisterUser(User user)
    {
        _usersList.Add(user);
    }

    public void SendMessage(string msg, User user)
    {
        foreach (var u in _usersList.Where(u => u != user))
        {
            u.Receive(msg);
        }
    }
}
