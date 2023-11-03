using System.Xml.Linq;

namespace Refresher
{
    public class Program
    {
        //creating empty list of players
        static List<Player> players = new List<Player>();
        static void Main(string[] args)
        {
            Preload();

            //ask user question
            DisplayQuestion();
            //Get user input and give input a value
            string userChoice = Console.ReadLine();

            if(userChoice == "1")
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine($"{players[i]}");
                }
            }
            else if (userChoice == "2")
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].Number % 2 != 0)
                    {
                        Console.WriteLine($"{players[i]}");
                    }
                }
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("Enter Letter: ");
                string userLetterInput = Console.ReadLine();
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].Name.StartsWith(userLetterInput, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine($"{players[i]}");
                    }
                }
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Enter Name: ");
                string newPlayerName = Console.ReadLine();
                Console.WriteLine("Enter Number: ");
                int newPlayerNumber = int.Parse(Console.ReadLine());
                Player player = new Player(newPlayerName, newPlayerNumber);
                players.Add(player);
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine($"{players[i]}");
                }
            }
            else
            {
                Console.WriteLine($"{userChoice} was not a correct input.");
            }
            void DisplayQuestion()
            {
                Console.WriteLine("Players\n" +
                "1 - Display Players\n" +
                "2 - Display Players with an Odd letter\n" +
                "3 - Display Players starting with a letter\n" +
                "4 - Add Player\n" +
                "Enter your choice");

            }
            void Preload()
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
            }
        }
    }
}