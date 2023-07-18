using System;
using System.Reflection.Metadata;

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
            Console.WriteLine(palindromeChecker);

            if (palindromeChecker == userChoice){

                Console.WriteLine("Congratulations the word is a ´palindrome!");


            }
            else
            {
                Console.WriteLine("the word is not a palindrome!");
            }

        }
    }
}
