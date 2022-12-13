using System;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked keyword: with this overflow will not happen at runtime and Exception will be thrown and program will crash unless u
            //handle exception.
            checked
            {
                byte number = 255;
                number += 1;//0

            }
        }

    }
}
