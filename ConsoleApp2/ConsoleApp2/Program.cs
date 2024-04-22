using ConsoleApp2;

// Клас ігрової сесії.

// Отримуємо єдиний екземпляр менеджера сесій.
var manager = GameSessionManager.GetInstance();

// Створюємо декілька ігрових сесій.
var session1 = manager.CreateSession("Session 1");
var session2 = manager.CreateSession("Session 2");

// Отримуємо список ігрових сесій через менеджер.
var sessions = manager.GetSessions();

// Виводимо назви всіх ігрових сесій.
foreach (var session in sessions)
{
    Console.WriteLine("Session Name: " + session.SessionName);
}

var manager2 = GameSessionManager.GetInstance();

Console.WriteLine(manager == manager2);