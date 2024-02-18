// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("r1: ");
    double r1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("r2: ");
    double r2 = Convert.ToDouble(Console.ReadLine());

    if (r1 < 0 || r2 < 0)
    {
        Console.WriteLine("can`t be negative.");
    }
    else if (r1 > r2)
    {
        Console.WriteLine("inner < outter.");
    }
    else
    {
        double area = Math.PI * (r2 * r2 - r1 * r1);
        Console.WriteLine($"S of circle: {area}");
    }
}

Console.WriteLine("Lab 1 !");
task1();
// continue ...
