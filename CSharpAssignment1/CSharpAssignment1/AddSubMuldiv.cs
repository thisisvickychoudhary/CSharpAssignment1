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
                Console.Write("Enter First Number: \n");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: \n");
                int num2 = Convert.ToInt32(Console.ReadLine());

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
