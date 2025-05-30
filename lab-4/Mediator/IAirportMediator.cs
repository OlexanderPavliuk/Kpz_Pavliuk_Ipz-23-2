public interface IAirportMediator
{
    bool RequestLanding(Aircraft aircraft);
    void NotifyTakeoff(Aircraft aircraft);
}