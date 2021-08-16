
using System;

namespace ProjectG
{
    class NewTestProgramm
    {
        public static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble (Console.ReadLine ());

            if (a > 10f) {
                Console.Write ("A is bigger than 10");
            } else if (a < 10F){
                Console.Write ("A  more less than 5");
            }
        }
    }
}
