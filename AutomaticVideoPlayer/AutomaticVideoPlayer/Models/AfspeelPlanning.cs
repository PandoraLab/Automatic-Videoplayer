namespace AutomaticVideoplayer.Models;

public class AfspeelPlanning
{
    public TimeOnly Starttijd { get; set; } = new(4, 0);
    public TimeOnly Stoptijd { get; set; } = new(10, 0);
}
