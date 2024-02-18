// See https://aka.ms/new-console-template for more information

 static void task2()
{
    Console.Write("Put 3 digit number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 100 || number > 999)
    {
        Console.WriteLine("number must have 3 digit.");
    }
    else
    {
        int digit1 = number / 100;
        int digit2 = (number / 10) % 10;
        int digit3 = number % 10;

        if (digit1 == digit2 && digit2 == digit3)
        {
            Console.WriteLine("all digits are same.");
        }
        else
        {
            Console.WriteLine("digits are not the same.");
        }
    }
}

Console.WriteLine("Lab 1 !");
task2();
// continue ...
