using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccoreproblem
{
    internal class flipcoin
    {
        public static void calculatepercentages()
        {
            Console.WriteLine("plese enter the no of time coin flip");
            int flipcoin=Convert.ToInt32(Console.ReadLine());
            int headcount=0,tailcount=0;    
            double headpercentage=0;
            double tailpercentage=0;    
            if (flipcoin>0)
            {
                for(int i=0;i<flipcoin;i++)
                {
                    Random random = new Random();   
                    double number =random.NextDouble();
                    if (number > 0.5) 
                    {
                        Console.WriteLine("head");
                        headcount++;
                    }
                    else
                    {
                        Console.WriteLine("tail");
                        tailcount++;
                    }
                }
                headpercentage = headcount * 100 / flipcoin;
                tailpercentage = tailcount * 100 / flipcoin;
                Console.WriteLine("head percentage"+headpercentage);
                Console.WriteLine("tail percentage"+tailpercentage);
            }
            else
            {
                Console.WriteLine("enter positive number");
            }
        }
    }
}
