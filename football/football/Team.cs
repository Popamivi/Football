using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    public class Team
    {
        public string Name { get; set; }
        public Coach Coach { get; set; }
        public FootballPlayer[] Players { get; set; }

        public double GetAverageAge()
        {
            int totalAge = 0;

            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }

            return (double)totalAge / Players.Length;
        }

        public void TeamIntroduce()
        {
            Console.WriteLine("Our team has the following players:");

            foreach (FootballPlayer player in Players)
            {
                player.Introduce();
            }
        }
    }
}
