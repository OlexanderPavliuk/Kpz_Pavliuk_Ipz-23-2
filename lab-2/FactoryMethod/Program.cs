using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SubscriptionCreator> creators = new List<SubscriptionCreator>
        {
            new WebSite(),
            new MobileApp(),
            new ManagerCall()
        };

            foreach (var creator in creators)
            {
                ISubscription subscription = creator.CreateSubscription();
                Console.WriteLine($"Type: {subscription.GetDescription()}");
                Console.WriteLine($"Monthly Fee: {subscription.MonthlyFee}$");
                Console.WriteLine($"Minimum Period: {subscription.MinimumPeriodMonths} months");
                Console.WriteLine($"Channels: {string.Join(", ", subscription.Channels)}");
                Console.WriteLine(new string('-', 40));
                Console.ReadLine();
            }
        }
    }
}