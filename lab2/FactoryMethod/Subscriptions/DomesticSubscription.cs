public class DomesticSubscription : ISubscription
{
    public decimal MonthlyFee => 9.99m;
    public int MinimumPeriodMonths => 1;
    public List<string> Channels => new List<string> { "News", "Entertainment", "Sports" };

    public string GetDescription() => "Domestic Subscription";
}