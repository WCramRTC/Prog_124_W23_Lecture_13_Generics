﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_13_Generics
{
    internal class FootballPlayer : Player
    {
        int _yardsThrown;

        public FootballPlayer(string name, string number, int yardsThrown) : base(name, number)
        {
            _yardsThrown = yardsThrown;
        }

        public int YardsThrown { get => _yardsThrown; set => _yardsThrown = value; }
    }
}
