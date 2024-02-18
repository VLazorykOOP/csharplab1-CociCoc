// See https://aka.ms/new-console-template for more information

 static void task4()
{
    Console.Write("write gender (m - men, w - woman): ");
    string gender = Console.ReadLine();

    if (gender == "m")
    {
        Console.WriteLine("mans name: Joe, John, Max.");
    }
    else if (gender == "w")
    {
        Console.WriteLine("womans name: Olena, Olga, Nina.");
    }
    else
    {
        Console.WriteLine("uncorrect gender.");
    }
}

Console.WriteLine("Lab 1 !");
task4();
// continue ...
