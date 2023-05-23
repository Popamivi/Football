using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Person[] AssistantReferees { get; set; }
        public string[] Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public void PlayGame()
        {
            Console.WriteLine("The game starts!");

            foreach (FootballPlayer player in Team1.Players)
            {
                player.Play();
            }

            foreach (FootballPlayer player in Team2.Players)
            {
                player.Play();
            }

            Console.WriteLine("The game is over!");
        }

        public void PrintResult()
        {
            Console.WriteLine("Game result: " + Result);
            Console.WriteLine("The winner is: " + Winner.Name);
        }
    }
}
