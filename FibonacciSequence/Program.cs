using System;

class Program
{
    private static void nthFibonacci(int nthTerm)//other way to do it is: Recursion
    {
        int number1 = 0;
        int number2 = 1;
        int nthNumber;

        if(nthTerm == 0)
        {
            Console.WriteLine("Term #0; 0");
        }
        else if(nthTerm == 1)
        {
            Console.WriteLine("term #1: 1");
        }
        else
        {
            for(int i = 0; i < nthTerm; i++)
            {
                Console.WriteLine("Term #" + i + ": " + number1);
                nthNumber = number1 + number2;
                number1 = number2;
                number2 = nthNumber;
            }
        }
    }



    public static void Main(string[] args)
    {
        while(true)
        {
            try
            {
                // Prompt the user
                Console.WriteLine("Please enter a number to calculate: ");
                int nthNumber = int.Parse(Console.ReadLine());
                //Calculate Fibonacci
                nthFibonacci(nthNumber);
            }
            catch
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }
    }
}