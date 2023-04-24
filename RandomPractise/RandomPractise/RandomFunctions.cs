using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractise
{
    public class RandomFunctions
    {
        const int Constant_Number = 5;
        public void NextMethods()
        {
            //Method Four - using NextDouble()
            Random next = new Random(); //object of random class.
            int i = 0;
            while (i <= Constant_Number) //Using this loop it will print until the condition is satisfied.
            {
                double randomNum = next.NextDouble(); //way to call "NextDouble()" method will return random
                                               //values greater than 0.0 and less than 1.0
                Console.WriteLine(randomNum);
                i++;
            }
        }
    }
}
