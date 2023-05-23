using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    public class Goalkeeper : FootballPlayer
    {
        public void Defend()
        {
            Console.WriteLine("I am a goalkeeper. I defend the goal.");
        }
    }
}
