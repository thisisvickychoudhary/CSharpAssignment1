using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment1
{
    public class Swap
    {
        public void swapNumber()
        {
            l1:
            int number1, number2, temp;

            try
            {
                Console.Write("First Number : \n");
                number1 = int.Parse(Console.ReadLine());
                Console.Write("Second Number : \n");
                number2 = int.Parse(Console.ReadLine());
                temp = number1;
                number1 = number2;
                number2 = temp;
                Console.Write("After Swapping : \n");
                Console.Write("First Number : " + number1);
                Console.Write("\nSecond Number : " + number2);
            }
            catch (FormatException) {
                Console.Write("Please Enter only Integer number\n");
                goto l1;
            }
          
            Console.Read();
        }
    }
}
