public class EducationalSubscription : ISubscription
{
    public decimal MonthlyFee => 5.99m;
    public int MinimumPeriodMonths => 3;
    public List<string> Channels => new List<string> { "Documentaries", "Science", "History" };

    public string GetDescription() => "Educational Subscription";
}