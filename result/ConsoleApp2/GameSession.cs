namespace ConsoleApp2;

public class GameSession
{
    // Назва сесії.
    public string SessionName { get; private set; }

    // Конструктор класу GameSession.
    public GameSession(string sessionName)
    {
        SessionName = sessionName;
    }
}