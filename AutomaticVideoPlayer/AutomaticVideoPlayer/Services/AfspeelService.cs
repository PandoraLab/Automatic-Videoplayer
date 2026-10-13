using AutomaticVideoplayer.Models;

namespace AutomaticVideoplayer.Services;

public class AfspeelService
{
    public bool MoetAfspelen(
        TimeOnly huidigeTijd,
        AfspeelPlanning planning)
    {
        return huidigeTijd >= planning.Starttijd
            && huidigeTijd < planning.Stoptijd;
    }
}