using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            SmallestNum(n1, n2, n3);
        }
        static int SmallestNum(int n1, int n2, int n3)
        {
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1);
                return n1;
                
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine( n2);
                return n2;
            }
            else
            {
                Console.WriteLine(n3);
                return n3;
            }
        }
            
    }
}
