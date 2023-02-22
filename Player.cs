using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_13_Generics
{
    public abstract class Player
    {
        string _name;
        string _number;

        public Player(string name, string number)
        {
            _name = name;
            _number = number;
        }

        public void PerformAction()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Number { get => _number; set => _number = value; }
    }
}
