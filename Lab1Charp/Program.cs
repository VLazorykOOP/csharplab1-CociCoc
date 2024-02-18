using System;

class Program
{
    static double SquareOfQuotient(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Dividing by zero is not possible.");
        }

        double quotient = num1 / num2;
        return quotient * quotient;
    }

    static void Main()
    {
        Console.Write("Enter the first number:: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        try
        {
            double result = SquareOfQuotient(num1, num2);
            Console.WriteLine($"Quotient square {num1} and {num2} equal {result}.");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}