using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    internal class RandomPlayer : Player
    {
        public override string Name { get; set; }
        public override Roshambo RoshamboValue { get; set; }

        public override Roshambo GenerateRoshambo()
        {
            Array values = Enum.GetValues(typeof(Roshambo));
            Random random = new Random();
            Roshambo randomRoshambo = (Roshambo)values.GetValue(random.Next(values.Length));
            return randomRoshambo;
        }
    }
}
