using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    public class Player
    {
        //Fields
        string _name;
        int _number;

        //constructor
        public Player(string name, int number)
        {
            _name = name;
            _number = number;
        }

        //properties
        public string Name { get => _name; set => _name = value; }
        public int Number { get => _number; set => _number = value; }

        //methods
        public override string ToString()
        {
            return $"Name - {_name} Number - {_number}";
        }

    }
}
