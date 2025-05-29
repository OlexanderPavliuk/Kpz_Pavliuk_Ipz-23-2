public class ManagerCall : SubscriptionCreator
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Created via Manager Call.");
        return new PremiumSubscription();
    }
}