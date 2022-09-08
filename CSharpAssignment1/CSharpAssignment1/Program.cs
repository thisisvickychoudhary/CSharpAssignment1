using System;

namespace CSharpAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.WriteLine("\n\nPress 1 to Execute Swap program");
            Console.WriteLine("Press 2 to Execute Arithmetic Program");
            Console.WriteLine("Press 3 to Execute Multiplication Table");
            Console.WriteLine("Press 4 to Execute check two Integer numbers");
            Console.WriteLine("Press 5 to Execute Display a Triangle");
            Console.WriteLine("Press 6 to Execute Sum of all element of the Array ");
            int choice;
            Console.Write("Please Enter your Choice 1 to 6\n");
            choice = int.Parse(Console.ReadLine());
            Console.Write("\nYou have entered {0}\n", choice);
            switch (choice)
            {
                case 1:
                    Swap obj1 = new Swap();
                    obj1.swapNumber();
                    break;
                case 2:

                    AddSubMuldiv obj2 = new AddSubMuldiv();
                    obj2.Arithmetic();
                    break;
                case 3:

                    MultiplicationTable obj3 = new MultiplicationTable();
                    obj3.Mul();
                     break;
                case 4:
                    Integer obj4 = new Integer();
                    obj4.Int();
                     break;
                case 5:
                    Triangle obj5 = new Triangle();
                    obj5.Tri();
                     break;
                case 6:
                    Array obj6 = new Array();
                    obj6.Arr();
                   break;

                default:
                    Console.WriteLine("Please Enter Valid Choice");
                    break;
            }
            Console.ReadLine();
            goto l1;


           
        }
    }
}
