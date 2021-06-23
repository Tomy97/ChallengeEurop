using System;

namespace ChallengeEurop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int den = 0;

            Console.WriteLine("Numerador: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---");
            Console.WriteLine("Denominador: ");
            den = Convert.ToInt32(Console.ReadLine());
            int div = 0;
            for (; ;)
            {
                for (int i = 9; i > 2; i--)
                {
                    div = 0;
                    if (num % i == 0 && den % i == 0 ) 
                    { 
                        div = i;
                        break; 
                    }
                }
                if (div == 0) { 
                    break; 
                }
                num = num / div;
                den = den / div;
            }
            Console.WriteLine(num);
            Console.WriteLine("---");
            Console.WriteLine(den);
        }
    }
}
