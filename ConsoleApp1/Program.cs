using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {

            List<Solution> solutions = new List<Solution>();
            //dollars
            for(int dollar = 0; dollar<6;dollar++)
            {
                for(int halfDollar = 0; halfDollar < 11 - (2 * dollar); halfDollar++)
                {
                    for(int quarter =0; quarter < 21 -((2* halfDollar) + (4*dollar)) ; quarter++)
                    {
                        for(int dime=0; dime < 51 - ((2.5 * quarter) + (5*halfDollar) + (10*dollar)); dime++)
                        {
                            for(int nickel=0; nickel<101 - ((2* dime) + (5*quarter) + (10 * halfDollar) + (20 * dollar));nickel++)
                            {
                                for(int penny=0; penny < 501 - ((5*nickel) + (10*dime) + (25*quarter) + (50*halfDollar) + (100*dollar)); penny += 5)
                                {
                                    if(sum(dollar, halfDollar, quarter,dime,nickel, penny) == 500)
                                    {
                                        solutions.Add(new Solution(dollar, halfDollar, quarter, dime, nickel, penny));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach(var solved in solutions)
            {
                Console.WriteLine(solved.ToString());
            }

            Console.WriteLine("number of solutions: " + solutions.Count().ToString());
        }

        private static int sum(int dollars, int halfDollar, int quarter, int dime, int nickel, int penny)
        {
            return ((dollars * 100) + (halfDollar * 50) + (quarter * 25) + (dime * 10) + (nickel * 5) + penny); 
        }
    }
}
