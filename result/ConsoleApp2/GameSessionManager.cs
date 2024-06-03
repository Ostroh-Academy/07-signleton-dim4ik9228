namespace ConsoleApp2;

public class GameSessionManager
{
    private static GameSessionManager? _instance;

    private readonly List<GameSession> _sessions;

    private GameSessionManager()
    {
        _sessions = new List<GameSession>();
    }

    public static GameSessionManager GetInstance()
    {
        return _instance ??= new GameSessionManager();
    }

    public GameSession CreateSession(string sessionName)
    {
        var session = new GameSession(sessionName);

        _sessions.Add(session);

        return session;
    }

    public List<GameSession> GetSessions()
    {
        return _sessions;
    }
}