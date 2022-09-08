using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment1
{
    public class AddSubMuldiv
    {
        public void Arithmetic()
        {
            try
            {
                Console.Write("Enter a number: \n");
                float num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: \n");
                float num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            }
            catch (FormatException)
            {
                Console.Write("Please Enter only Integer Number\n");
            }

            catch (Exception) {
                Console.Write("Divide by Zero is not allowed \n");
            }

        }
    }
}
