string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("************* Vykreslení obdélníku *************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Marcus Just *****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine();

    Console.Write("Zadejte šířku obdélníka (celé číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdélníka znovu: ");
    }


    Console.Write("Zadejte výšku obdélníka (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníka znovu: ");
    }

    for (int i = 1; i <= height; i++) {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}