using System;

namespace ReverseString // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a word");
            string userChoice = Console.ReadLine();
            string palindromeChecker = "";

            for (int i = userChoice.Length-1; i >= 0 ; i--) {

                palindromeChecker += userChoice[i];
                
            } 
            Console.WriteLine(palindromeChecker.ToLower());

            if (palindromeChecker.ToLower() == userChoice.ToLower()){

                Console.WriteLine("Congratulations the word is a palindrome!");


            }
            else
            {
                Console.WriteLine("the word is not a palindrome!");
            }

        }
    }
}
