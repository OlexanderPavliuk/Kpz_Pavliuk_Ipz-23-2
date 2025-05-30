public abstract class SupportHandler : IHandler
{
    protected SupportHandler _next;

    public void SetNext(SupportHandler next)
    {
        _next = next;
    }

    public abstract void HandleRequest();
}