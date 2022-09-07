

namespace basiccoreproblem
{
    internal class HarmonicNumber
    {
        public static void HarmonicNo()
        {
            Console.WriteLine("enter the nth number:");
            int number = int.Parse(Console.ReadLine());
            double j = 0;
            for (double i = 1; i <= number; i++)
            {
                j = j + 1 / i;
                Console.WriteLine(j);
            }
            Console.WriteLine("Sum of nth harmonic number" + j);
        }
    }
}
