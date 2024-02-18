// See https://aka.ms/new-console-template for more information

 static void task6()
{
    Console.Write("enter a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("enter b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    double result = (a + b - 1) / (a + b + 1 - a * b);
    Console.WriteLine("Result: " + result);
}

Console.WriteLine("Lab 1 !");
task6();
// continue ...
