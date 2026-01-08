﻿using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************************");
    Console.WriteLine("************* Největší ze tří čísel *************");
    Console.WriteLine("*************************************************");
    Console.WriteLine("**************** Marcus Just ********************");
    Console.WriteLine("*************************************************");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo A znovu: ");
    }

    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo B znovu: ");
    }

    Console.Write("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo C znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("===============================================");
    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největší je číslo A = {a}");
        else
            Console.WriteLine($"Největší je číslo C = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší je číslo B = {b}");
        else
            Console.WriteLine($"Největší je číslo C = {c}");
    }

    Console.WriteLine("===============================================");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}