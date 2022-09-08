using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment1
{
    public class Integer
    {
        public void Int()
        {
            try
            {

                Console.WriteLine("Input first integer :\t");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input second integer :\t");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter only Integer number\n");
            }

        }
    }
}
