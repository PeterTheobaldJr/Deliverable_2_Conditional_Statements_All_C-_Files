/*
Author : Peter Theobald Jr
Date: 1/24/23
Description: This is C# console application provides practical examples
of conditional statements
*/
using System; // Calling the library 
namespace Conditional_Statements_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // IF/ ELSE IF/ ELSE

            Console.WriteLine("Enter some number: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 > 1000)
            {
                Console.WriteLine("The input is greater than 1000");
                Console.ReadKey(true);
            }
            else if ((n1 > 500)&&(n1 <1000))
            {
                Console.WriteLine("The input is between 500 and 1000");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("The input is less than or equal to 1000");
                Console.ReadKey(true);
            }
            // Try Catch

            try
            {
                Console.WriteLine("Enter some integer number (n2): ");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The input is: " + n2);
                Console.ReadKey(true);

            }
            catch
            {
                Console.WriteLine("Please use intergar number");
                Console.ReadKey(true);
            }
            // Switch

            Console.WriteLine("Enter some integar number (n3): ");
            int n3 = int.Parse(Console.ReadLine());

            switch (n3)
            {
                case 0:
                    Console.WriteLine("Input is 0");
                    Console.ReadKey(true);
                    break;

                case 1:
                    Console.WriteLine("Input is 1");
                    Console.ReadKey(true);
                    break;
                case 2:
                    Console.WriteLine("Input is 2");
                    Console.ReadKey(true);
                    break;

                default:
                    Console.WriteLine("Input is not in range [0,2]");
                    Console.ReadKey(true);
                    break;

            }

        
        }
    }
}
