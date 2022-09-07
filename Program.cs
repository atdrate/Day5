

namespace basiccoreproblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic core program");
            Console.WriteLine("choose option\n 1 flip coin percentage \n 2 find leap year or not \n 4 print addition of nth harmoni no \n 6 compute quotient and reminder \n 7 swapping of two number \n 8 even or odd \n 9 vowel or consonent check \n 10 find largest number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    flipcoin.calculatepercentages();
                    break;
                case 2:
                    leapyear.checkleapyear();
                    break;
                case 4:
                    HarmonicNumber.HarmonicNo();
                    break;
                case 6:
                    QuotientReminder.Quotandreminder();
                    break;
                case 7:
                    SwapTwoNumber.swapnumber();
                    break;
                case 8:
                    EvenOdd.EvenOddCheck();
                    break;
                case 9:
                    VowelOrConsonent.VowelsConsoCheck();
                    break;
                case 10:
                    LargestNumber.largestNo();
                    break;

                    default: Console.WriteLine("select correct choice");
                    break;
                    
            }
        }
    }
}