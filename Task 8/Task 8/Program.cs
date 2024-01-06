using System.Diagnostics.CodeAnalysis;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {


        #region Task 1
        l1:
            Console.Write("Enter a number a:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");

                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
                goto l1;
            }
        #endregion


        #region Task 2
        l2:
            Console.Write("Enter  the first number:");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number:");
            string input2 = Console.ReadLine();

            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                if (number2 != 0 && number1 % number2 == 0)
                {
                    int result = number1 / number2;
                    Console.WriteLine($"Your result is:{result}");
                }
                else
                {
                    Console.WriteLine("Not divided");

                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
                goto l2;
            }

        #endregion


        #region Task 3
        l3:
            Console.Write("Enter your number:");
            string input3 = Console.ReadLine();

            if (int.TryParse(input3, out int number3))
            {
                int lastdigit = number3 % 10;
                if (lastdigit == 7)
                {
                    Console.WriteLine("Your number ends with 7");
                }
                else
                {
                    Console.WriteLine("Your number does not end with 7");

                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                goto l3;

            }
        #endregion


        #region Task 4
        l4:
            Console.Write("Enter a two-digit number:");
            string input4 = Console.ReadLine();

            if (int.TryParse(input4, out int number4) && number4 >= 10 && number4 <= 99)
            {
                int firstDigit = number4 / 10;
                int lastDigit = number4 % 10;

                if (firstDigit == lastDigit)
                {
                    Console.WriteLine("Yes,the digits are the same");
                }
                else
                {
                    Console.WriteLine("No,the digits are not the same");
                }
            }
            else
            {
                Console.WriteLine("Please,enter a valid two-digit numbeR!");
                goto l4;
            }
            #endregion


        #region Task 5
            Console.Write("Enter a two-digit number: ");
            int number5;

            if (int.TryParse(Console.ReadLine(), out number5) && number5 >= 10 && number5 <= 99)
            {

                int digit1 = number5 / 10;
                int digit2 = number5 % 10;


                if (digit1 % 2 == 0 && digit2 % 2 == 0)
                {
                    int product = digit1 * digit2;
                    Console.WriteLine($"Product of the digits:{product}");
                }
                else
                {
                    Console.WriteLine("Number contains an odd digit.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid two-digit number.");
            }
        }
        #endregion
















    }
} 
