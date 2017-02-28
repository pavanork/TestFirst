using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int Number = 1;
            const float pi = 3.14f;
            bool isWorking = false; ;
            number = 0;//You need to inititalize the variable unless a compile error gets fired
            Console.WriteLine($"{number} {Number} {pi}{isWorking}");
            Console.WriteLine();
            Console.WriteLine("hello Git!!");
            Console.WriteLine("You are awesomely awesome Git!!");

            int xx=300;
            byte bb = (byte)xx;
            Console.WriteLine(bb);
            //Console.WriteLine($"{ Convert.ToInt32("A")}");

            double x = 9.89;
            int y = (int)x;
            Console.ReadLine();

        }
    }
}
