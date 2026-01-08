string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************************");
    Console.WriteLine("************* Generátor pseudonáodných čísel + informace *************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Marcus Just *****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine();

    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet znovu: ");
    }

    Console.Write("Zadejte počet dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte počet horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("==========================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("==========================================================");
    Console.WriteLine();

    //deklarace pole - abychom měli čísla kam ukládat
    int[] myRandNumbs = new int[n];

    //příprava pro generování náhodných čísel
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(10);

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");

    // kladná, záporná a nuly
    int positiveNumbs = 0;
    int negativeNumbs = 0;
    int zeros = 0;

    // sudá a lichá
    int evenNumbs = 0;
    int oddNumbs = 0;

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);

        // kladná, záporná a nuly
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        else if (myRandNumbs[i] < 0)
            negativeNumbs++;
        else zeros++;

        // sudá a lichá
        if (myRandNumbs[i] % 2 == 0)
            evenNumbs++;
        else oddNumbs++;
    }

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("=============================================");
    Console.WriteLine("Počet záporných: {0}", negativeNumbs);
    Console.WriteLine("Počet kladných: {0}", positiveNumbs);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("=============================================");
    Console.WriteLine("Počet sudých: {0}", evenNumbs);
    Console.WriteLine("Počet lichých: {0}", oddNumbs);
    Console.WriteLine("=============================================");
    Console.WriteLine("=============================================");    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}