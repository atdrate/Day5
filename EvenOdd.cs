using System;


namespace basiccoreproblem
{
    internal class EvenOdd
    {
        public static void EvenOddCheck()
        {
            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("even number");
            else
                Console.WriteLine("odd number");
        }
    }
}
