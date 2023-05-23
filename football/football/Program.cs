using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Goalkeeper goalkeeper = new Goalkeeper { Name = "John", Age = 25, Number = 1, Height = 180 };
            Defender defender = new Defender { Name = "David", Age = 28, Number = 5, Height = 185 };
            Midfielder midfielder = new Midfielder { Name = "Michael", Age = 24, Number = 10, Height = 175 };
            Striker striker = new Striker { Name = "Daniel", Age = 22, Number = 9, Height = 180 };

            Coach coach = new Coach { Name = "Alex", Age = 40 };

            Team team1 = new Team { Coach = coach, Players = new FootballPlayer[] { goalkeeper, defender, midfielder, striker } };

            team1.TeamIntroduce();

            double averageAge = team1.GetAverageAge();
            Console.WriteLine("Average age of the team: " + averageAge);

            Team team2 = new Team { Coach = coach, Players = new FootballPlayer[] { goalkeeper, defender, midfielder, striker } };

            Game game = new Game { Team1 = team1, Team2 = team2 };

            game.PlayGame();
            game.PrintResult();

            Console.ReadKey();
        }
    }
}

