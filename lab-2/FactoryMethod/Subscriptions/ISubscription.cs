public interface ISubscription
{
    decimal MonthlyFee { get; }
    int MinimumPeriodMonths { get; }
    List<string> Channels { get; }
    string GetDescription();
}