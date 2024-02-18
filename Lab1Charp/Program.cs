// See https://aka.ms/new-console-template for more information

 static void task3()
{
    Console.Write("coordinate x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("coordinate y: ");
    double y = Convert.ToDouble(Console.ReadLine());

    if (y > x && y < 12 - x)
    {
        Console.WriteLine("yes");
    }
    else if (y == x || y == 12 - x)
    {
        Console.WriteLine("on edge");
    }
    else
    {
        Console.WriteLine("no");
    }
}

Console.WriteLine("Lab 1 !");
task3();
// continue ...
