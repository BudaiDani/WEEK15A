using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Room(int number)
        {
            this.number = number;
        }
    }
}
