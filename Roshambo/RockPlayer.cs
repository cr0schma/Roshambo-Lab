﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    internal class RockPlayer : Player
    {
        public override string Name { get; set; }
        public override Roshambo RoshamboValue { get; set; }

        public override Roshambo GenerateRoshambo()
        {   
            return Roshambo.rock;
        }
    }
}
