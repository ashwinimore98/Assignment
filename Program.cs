using System;

namespace NEW
{
    class Program
    {
        static void Main(string[] args)

        {
            //Leap year
            int year;
            Console.Write(" Enter Year = ");
            year = int.Parse(Console.ReadLine());
        
        
         
            if(((year % 4 == 0) && (year %100 != 0)) || (year %400 == 0))
            { 
                Console.WriteLine(" Leap Year " + year);
            }
            else
            {
                Console.WriteLine(" Not a Leap Year " + year);
            }
            Console.ReadLine();
        }
    }
}
