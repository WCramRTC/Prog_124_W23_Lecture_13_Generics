using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_13_Generics.Notes
{
    internal class FootballPlayer : Player
    {
        int _yardsRun;

        public FootballPlayer(string name, string number, int yardsRun) : base(name, number)
        {
            _yardsRun = yardsRun;
        }

        public int YardsRun { get => _yardsRun; set => _yardsRun = value; }
    }
}
