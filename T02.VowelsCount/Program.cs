using System;

namespace T02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            NumOfVowels(text);


        }
        static void NumOfVowels(string input)
        {
            int count = 0;
            foreach (char vowels in input)
            {
                if ("aeiou".Contains(vowels))
                {
                    count++;
                }


            }
            Console.WriteLine(count);


        }


    }
}
