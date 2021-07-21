using System;

namespace EvenNumberFromGivennumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int n = 0;
            while (n < 10)
            {

                num = num + 1;

                if (num % 2 == 0)
                {

                    Console.Write(num + " ");

                    n = n + 1;
                }
            }
        }

            

       

    
    }
}
