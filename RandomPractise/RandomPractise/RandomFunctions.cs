using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractise
{
    public class RandomFunctions
    {
        const int Constant_Number = 5;
        public void NextMethods()
        {
            //Method Five - using NextByte()
            Random output = new Random(); //object of random class.
            byte[] nextByteMethod = new byte[5];
            output.NextBytes(nextByteMethod); //using this method fills randoms numbers in array of bytes.
            foreach (byte element in nextByteMethod) //Using this repeatation it will print all the values of array named nextByteMethod.
            {
                Console.WriteLine(element);
            }
        }
    }
}
