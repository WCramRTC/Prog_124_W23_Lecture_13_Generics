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
        double _salary;

        public Player(string name, string number, double salary)
        {
            _name = name;
            _number = number;
            _salary = salary;
        }

        public Player()
        {

        }

        public void PerformAction()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Number { get => _number; set => _number = value; }
        public double Salary { get => _salary; set => _salary = value; }
    }
}
