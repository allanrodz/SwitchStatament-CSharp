using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Switch Statement ***********\n");

            int num;


            Console.Write("Enter a number (1-3): ");
            num = int.Parse(Console.ReadLine());

            switch(num)
            {

                case 1:
                    Console.WriteLine("You have selected the first statement");
                    break;
                case 2:
                    Console.WriteLine("You have selected the second statement");
                    break;
                case 3:
                    Console.WriteLine("You have selected the third statement");
                    break;
                default:
                    Console.WriteLine("You have entered an invalid number");
                    break;

            }

            Console.ReadLine();
        }
    }
}
