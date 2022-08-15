using System;

namespace hormonic
{
    namespace HARMONIC111
    {
        class Program

        {
            static void Main(string[] args)
            {
                HarmonicNumber(n: 3);

            }
            public static void HarmonicNumber(int n)//3
            {

                Double result = 0;//1
                for (int i = 1; i <= n; i++)//i=3
                {
                    result = (result + 1) / i;//
                }
                Console.WriteLine($"Harmonic number= {result}");
            }

        }
    }
}





