public class PremiumSubscription : ISubscription
{
    public decimal MonthlyFee => 19.99m;
    public int MinimumPeriodMonths => 6;
    public List<string> Channels => new List<string> { "Movies", "Premium Sports", "4K Streaming" };

    public string GetDescription() => "Premium Subscription";
}