using System;

public class Aircraft
{
    public string Name { get; }
    public bool IsTakingOff { get; set; }
    private readonly IAirportMediator _mediator;

    public Aircraft(string name, IAirportMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public void Land()
    {
        Console.WriteLine($"Aircraft {Name} is requesting landing.");
        if (_mediator.RequestLanding(this))
        {
            Console.WriteLine($"Aircraft {Name} has landed successfully.");
        }
        else
        {
            Console.WriteLine($"Aircraft {Name} could not land. All runways busy.");
        }
    }

    public void TakeOff()
    {
        Console.WriteLine($"Aircraft {Name} is taking off.");
        _mediator.NotifyTakeoff(this);
        Console.WriteLine($"Aircraft {Name} has taken off.");
    }
}
