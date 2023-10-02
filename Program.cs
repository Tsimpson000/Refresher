using System.Xml.Linq;

namespace Refresher
{
    internal class Program
    {
        //creating empty list of players
        static List<Player> players = new List<Player>();
        static void Main(string[] args)
        {
            //create new players
            Player player1 = new Player("Shiva", 45);
            Player player2 = new Player("Tyler", 30);
            Player player3 = new Player("Fluffy", 36);
            Player player4 = new Player("Odin", 100);
            Player player5 = new Player("Tinsil", 85);

            //add players to list
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(player5);

            //display list
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{players[i]}");
            }
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Number % 2 != 0)
                {
                    Console.WriteLine($"{players[i]}");
                }
            }
        }
    }
}