public class WebSite : SubscriptionCreator
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Created via Website.");
        return new DomesticSubscription();
    }
}