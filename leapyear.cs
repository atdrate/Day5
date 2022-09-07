



namespace basiccoreproblem
{
    internal class leapyear
    {
        public static void checkleapyear()
        {

            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 1000 && year <= 9999)
            {
                if ((year % 4 == 0) && (year % 100 != 0 || (year % 400 == 0)))
                {
                    Console.WriteLine("leap year");
                }
                else
                {
                    Console.WriteLine("not leap year");
                }
            }
            else
            {
                Console.WriteLine("enter valid year of four digit");
            }
        }   }
}
