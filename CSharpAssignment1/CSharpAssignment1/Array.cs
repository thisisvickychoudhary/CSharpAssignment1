using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment1
{
    public class Array
    {
        public void Arr() {
            l1:
            int[] a = new int[3];
            int i, sum = 0;


            Console.Write("\n\nFind sum of all elements of array:\n");
            try
            {
                for (i = 0; i < a.Length; i++)
                {
                    Console.Write("element - {0} : ", i);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (FormatException) {
                Console.Write("Please Enter Only Integer number\n");
                goto l1;
            }
            
            for (i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}", sum);


        }
    }
}
