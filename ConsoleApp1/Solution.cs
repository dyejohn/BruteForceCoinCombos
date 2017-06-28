using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Dollars { get; set; }
        public int HalfDollars { get; set; }
        public int Quarters { get; set; }
        public int Dimes { get; set; }
        public int Nickels { get; set; }
        public int Pennies { get; set; }

        public Solution(int dollars, int halfDollars, int quarters, int dimes, int nickels, int pennies)
        {
            this.Dollars = dollars;
            this.HalfDollars = halfDollars;
            this.Quarters = quarters;
            this.Dimes = dimes;
            this.Nickels = nickels;
            this.Pennies = pennies;
        }

        public override string ToString()
        {
            return string.Format(" Dollars: {0}, Half Dollars: {1}, Quarters: {2}, Dimes: {3}, Nickels {4}, Pennies {5}", this.Dollars, this.HalfDollars, this.Quarters, this.Dimes, this.Nickels, this.Pennies);
        }
    }
}
