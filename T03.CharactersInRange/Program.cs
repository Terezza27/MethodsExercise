using System;

namespace T03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharsInRange(firstChar, secondChar);

        }

        static void CharsInRange(char firstchar, char secondChar)
        {
            int startChar = Math.Min(firstchar, secondChar);
            int endChar = Math.Max(firstchar, secondChar);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }
    }
}
