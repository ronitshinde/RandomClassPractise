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
            //Method One - using Next()
            Random next = new Random(); //object of random class
            for (int i = 0; i < Constant_Number; i++)
            {
                int randomNum = next.Next(); //way to call "Next()" method
                Console.WriteLine(randomNum);
            }
        }
    }
}
