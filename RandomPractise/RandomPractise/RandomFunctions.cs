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
            //Method Two - using Next(int)
            Random next = new Random(); //object of random class.
            int i = 0;
            while (i <= Constant_Number) //Using this loop it will print until the condition is satisfied.
            {
                int randomNum = next.Next(10); //way to call "Next(int)" method will return random values less than 10.
                Console.WriteLine(randomNum);
                i++;
            }
        }
    }
}
