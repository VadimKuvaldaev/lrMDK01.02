using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant
{
    public class Table
    {

        public int Number { get; set; }
        public int Seats { get; set; }

        public Table(int number, int seats)
        {
            Number = number;
            Seats = seats;
        }
    }
}
