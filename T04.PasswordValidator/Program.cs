using System;

namespace T04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLenghtCorect = CorectLenght(password);
            bool isDigitsOrLetters = DigitsOrLetters(password);
            bool isContainingDigits = ContainingDigits(password);

            if (!isLenghtCorect)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isDigitsOrLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isContainingDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLenghtCorect && isDigitsOrLetters && isContainingDigits)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool CorectLenght(string password)
        {
            return password.Length > 6 && password.Length < 10;
        }

        static bool DigitsOrLetters(string password)
        {
            foreach (char Character in password)
            {
                if (!char.IsLetterOrDigit(Character))
                {
                    return false;
                }

            }

            return true;
        }

        static bool ContainingDigits(string password)
        {
            int countDigit = 0;
            foreach (char Character in password)
            {
                if (char.IsDigit(Character))
                {
                    countDigit++;
                }

            }
            return countDigit >= 2;
        }
    }
}
