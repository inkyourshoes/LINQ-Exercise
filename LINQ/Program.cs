namespace LINQ
{
    public class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
            { "GTA.V", "Smash Bros", "007" };
            
            videoGames.Add("Minecraft");
            videoGames.Add("Fortnite");

            var orderedGames = videoGames.OrderBy(name => name.Length);
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
