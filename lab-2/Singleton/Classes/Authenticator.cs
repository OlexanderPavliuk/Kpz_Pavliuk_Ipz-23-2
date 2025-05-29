using System;

public sealed class Authenticator
{
    private static readonly Lazy<Authenticator> instance = new Lazy<Authenticator>(() => new Authenticator());

    public static Authenticator Instance => instance.Value;

    // Приватний конструктор — забороняє створення ззовні
    private Authenticator()
    {
        Console.WriteLine(">> Authenticator created");
    }

    // Приклад методу
    public void Authenticate(string user)
    {
        Console.WriteLine($"Authenticating user: {user}");
    }
}
