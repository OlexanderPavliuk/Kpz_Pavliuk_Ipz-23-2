using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Моделюємо багатопотоковий доступ
        Thread t1 = new Thread(() => UseAuthenticator("Alice"));
        Thread t2 = new Thread(() => UseAuthenticator("Bob"));
        Thread t3 = new Thread(() => UseAuthenticator("Charlie"));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("All authentications complete.");
        Console.ReadLine();
    }

    static void UseAuthenticator(string username)
    {
        var auth = Authenticator.Instance;
        auth.Authenticate(username);
    }
}
