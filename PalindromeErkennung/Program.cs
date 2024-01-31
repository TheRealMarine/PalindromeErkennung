using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "numbers.txt";
        int palindromeSum = 0;
        string line;
        
        StreamReader numbersfile = new StreamReader(filePath);

        while ((line = numbersfile.ReadLine()) != null)
        {
            // Removes Special Characters
            line = line.Replace('"'.ToString(), string.Empty); // Removes " from the Numbers.txt
            line = line.Replace(','.ToString(), string.Empty); // Removes , from the Numbers.txt
            Console.WriteLine("Original: " + line); // Debug! Can be removed

            // Reverses the given String
            char[] reversedCharArray = line.ToCharArray();
            Array.Reverse(reversedCharArray);
            string reversedLine = new string(reversedCharArray);
            Console.WriteLine("Reversed: " + reversedLine); // Debug! Can be removed

            // Checks Palindrome and adds the decimal value of the binary Palindrome to a Sum
            if (line == reversedLine) // Checks if the original and reversed line are matching
            {
                Console.WriteLine("Ist Palindrome: " + reversedLine); // Debug! Can be removed
                palindromeSum += Convert.ToInt32(line, 2); // Add the Palindrome to the Sum after converting it to Decimal Number System
            }
        }

        Console.WriteLine("Der dezimale Gesamtwert aller Palindrome in Numbers.txt beträgt: " + palindromeSum);
    }
}
