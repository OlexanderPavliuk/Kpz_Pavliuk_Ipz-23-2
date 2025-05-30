using System;
using System.Collections.Generic;

public class CommandCentre : IAirportMediator
{
    private readonly List<Runway> _runways = new();
    private readonly Dictionary<Aircraft, Runway> _aircraftAssignments = new();

    public CommandCentre(IEnumerable<Runway> runways)
    {
        _runways.AddRange(runways);
    }

    public bool RequestLanding(Aircraft aircraft)
    {
        foreach (var runway in _runways)
        {
            if (runway.IsBusyWithAircraft == null)
            {
                runway.IsBusyWithAircraft = aircraft;
                runway.HighLightRed();
                _aircraftAssignments[aircraft] = runway;
                return true;
            }
        }
        return false;
    }

    public void NotifyTakeoff(Aircraft aircraft)
    {
        if (_aircraftAssignments.TryGetValue(aircraft, out var runway))
        {
            runway.IsBusyWithAircraft = null;
            runway.HighLightGreen();
            _aircraftAssignments.Remove(aircraft);
        }
    }
}
