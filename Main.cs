using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyberte z nabídky");
            Console.WriteLine("1) Čtverec");
            Console.WriteLine("2) Obdélník");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Zadejte stranu čtverce:");
                int length = Convert.ToInt32(Console.ReadLine());
                int result = length * length;
                Console.WriteLine($"Obsah čtverce je {result}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Zadejte délku první strany:");
                int length1 = Convert.ToInt32(Console.ReadLine());

                int length2;
                while (true)
                {
                    Console.WriteLine("Zadejte délku druhé strany (nesmí být stejná jako první):");
                    length2 = Convert.ToInt32(Console.ReadLine());
                    if (length2 != length1)
                        break;
                    else
                        Console.WriteLine("Druhá strana nesmí být stejná jako první. Zkuste to znovu.");
                }

                int result = length1 * length2;
                Console.WriteLine($"Obsah obdélníku je {result}");
            }
            else
            {
                Console.WriteLine("Neplatná volba.");
            }
        }
    }
}
