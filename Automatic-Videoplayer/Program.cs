namespace Automatic_Videoplayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();

            Planning planning = new Planning(
                new TimeOnly(4, 0),
                new TimeOnly(10, 0)
            );

            Console.WriteLine($"TV starttijd: {planning.Starttijd}");
            Console.WriteLine($"TV eindtijd: {planning.Eindtijd}");

            tv.AanZetten();

            Console.WriteLine($"TV status: {tv.IsAan}");
        }
    }
}