

namespace basiccoreproblem
{
    internal class SwapTwoNumber
    {
        public static void swapnumber()
        {
            int temp;
            Console.WriteLine("enter the first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            int number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("after swapping");
            Console.WriteLine("first number:{0}\nsecond number:{1}", number1, number2);
        }
    }
}
