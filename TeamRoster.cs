using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_13_Generics
{
    internal class TeamRoster<T> where T : Player
    {
        public List<T> _roster = new List<T>();

        // Build a method to add a PLayer to our roster
        public void AddPlayer(T player)
        {
            _roster.Add(player);
        }



    }
}
