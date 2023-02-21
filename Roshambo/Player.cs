using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    internal abstract class Player
    {
        public abstract string Name { get; set; }
        public abstract Roshambo RoshamboValue { get; set; }
        public abstract Roshambo GenerateRoshambo();
        
    }
}
