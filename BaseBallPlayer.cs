﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_13_Generics
{
    internal class BaseBallPlayer : Player
    {
        int _atBat;

        public BaseBallPlayer(string name, string number, double salary, int atBat) : base(name, number, salary)
        {
            _atBat = atBat;
        }

        public int AtBat { get => _atBat; set => _atBat = value; }
    }
}
