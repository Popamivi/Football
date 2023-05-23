using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public void Play()
        {
            Console.WriteLine("I am a football player with number " + Number + ".");
        }
    }
}
