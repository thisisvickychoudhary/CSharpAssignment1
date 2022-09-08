using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment1
{
    public class Triangle
    {
        public void Tri()
        {
            try
            {
                Console.Write("Enter a number: \n");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the desired width: \n");
                int width = Convert.ToInt32(Console.ReadLine());

                int height = width;
                for (int row = 0; row < height; row++)
                {
                    for (int column = 0; column < width; column++)
                    {
                        Console.Write(num);
                    }

                    Console.WriteLine();
                    width--;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter Only Integer number");
            }
        }

    }
}
