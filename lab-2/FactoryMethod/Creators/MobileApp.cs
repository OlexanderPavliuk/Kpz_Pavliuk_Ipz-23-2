public class MobileApp : SubscriptionCreator
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Created via Mobile App.");
        return new EducationalSubscription();
    }
}