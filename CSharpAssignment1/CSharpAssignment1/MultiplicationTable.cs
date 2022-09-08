using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment1
{
    public class MultiplicationTable
    {
        public void Mul()
        {
            try
            {
                int i, num;

                //Reading number
                Console.WriteLine("Enter a Number to print table: ");
                num = Convert.ToInt32(Console.ReadLine());


                for (i = 1; i <= 5; i++)
                {
                    //Printing table of number entered by user            
                    Console.Write("{0} X {1} = {2} \n", num, i, num * i);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please Enter only Integer number");
            }  
        }

    }
}
