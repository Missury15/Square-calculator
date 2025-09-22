using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Vyberte z nabídky");
      Console.WriteLine("1) čtverec");
      Console.WriteLine("2) Obdelním");

      Int choice = Console.ReadaLine();
        if (choice == 1);
        {
          Console.WriteLine("Zadejte stranu čtverce");
          Int length = Console.ReadLine();
          Int result = length * length;
            Console.WriteLine("Obsah čtverce je {result});
           }
    }
  }
}
