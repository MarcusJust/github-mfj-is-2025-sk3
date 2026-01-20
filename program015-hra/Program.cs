using System;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("========== POSLEDNÍ ZÁPALKA ==========");
            Console.WriteLine("Vezmi 1–3 zápalky. Kdo vezme poslední, prohrál.");
            Console.WriteLine();

            int zapalky = 20;
            bool hracNaTahu = true;

            while (zapalky > 0)
            {
                Console.WriteLine($"Zápalky: {new string('|', zapalky)} ({zapalky})");
                Console.WriteLine();

                if (hracNaTahu)
                {
                    Console.Write("Kolik zápalek vezmeš (1–3): ");
                    if (!int.TryParse(Console.ReadLine(), out int tah) ||
                        tah < 1 || tah > 3 || tah > zapalky)
                    {
                        Console.WriteLine("Neplatný tah!");
                        continue;
                    }

                    zapalky -= tah;

                    if (zapalky == 0)
                    {
                        Console.WriteLine("\n❌ Vzal jsi poslední zápalku – PROHRÁL jsi!");
                        break;
                    }
                }
                else
                {
                    // jednoduchá (ale chytrá) strategie počítače
                    int tah = (zapalky - 1) % 4;
                    if (tah == 0) tah = 1;

                    Console.WriteLine($"Počítač bere {tah} zápalky.");
                    zapalky -= tah;

                    if (zapalky == 0)
                    {
                        Console.WriteLine("\n🎉 Počítač vzal poslední zápalku – VYHRÁL jsi!");
                        break;
                    }
                }

                hracNaTahu = !hracNaTahu;
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Pro opakování stiskni 'a': ");
            again = Console.ReadLine();
        }
    }
}