using System;

namespace factor
{
    class Program
    {
      static void Main(string[] args)
      {
            Console.WriteLine("Plese provide input number");
            int input = Int32.Parse(Console.ReadLine());
       
  
            for(int i=1;i<=input;i++)
            {
                if(input%i==0)
                {
                    Console.WriteLine($"{i} is the factor of {input}");//1
                }
            }

           
      }
        
    }
}
