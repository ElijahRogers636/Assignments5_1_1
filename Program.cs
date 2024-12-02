namespace Assignments5_1_1
{
    internal class Program
    {
        // Given an integer x, return true if x is a palindrome, and false otherwise.
        static void Main(string[] args)
        {
            PrintPrompt(141); //True
            PrintPrompt(140); //False
            PrintPrompt(30511503); //True
            PrintPrompt(-121); //False
            PrintPrompt(040); //False
            
        }

        // Mathimatically checks if an int is a plaindrome
        static bool IsIntPalindrome(int num)
        {
            int temp = num;
            int reversedNum = 0;

            if (num == 0) return true; // If num is 0 it is a plaindrome
            if (num < 0 || num % 10 == 0) return false; // Check for negatives with (num < 0) or check if num % 10 == 0 (if last digit is 0 return false, ints dont lead with 0); 

            // Reverse int until temp is 0
            while (temp != 0)
            {
                // Multiply the "reverse" number by 10 (to set up the reversed num to add the next digit) and add the remainder of temp (next digit taken from the end of temp)
                reversedNum = (reversedNum * 10) + temp % 10; 
                temp = temp / 10; // remove the digit on the end on the integer
            }

            // Return if reversed number is equal to the original number
            return reversedNum == num;
        }

        // Prints the prompt
        static void PrintPrompt(int num)
        {
            Console.WriteLine($"Is { num } palindromic integer?");
            Console.WriteLine(IsIntPalindrome(num));
            Console.WriteLine();
        }
    }
}
