using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    public class Referee : Person
    {
        public void MakeDecisions()
        {
            Console.WriteLine("I am a referee. I make decisions during the game.");
        }
    }
}
