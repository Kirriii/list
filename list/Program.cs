using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // skapar listan
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // skriver ut varje siffra och dess index
        Console.WriteLine("Siffrorna i listan:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"Index {i}: Värde {numbers[i]}");
        }

        // undersöker om en viss siffra finns i listan
        int valueToCheck = 30;
        if (numbers.Contains(valueToCheck))
        {
            Console.WriteLine($"\nSiffran {valueToCheck} finns i listan, tar bort den...");
            numbers.Remove(valueToCheck);
        }
        else
        {
            Console.WriteLine($"\nSiffran {valueToCheck} finns inte i listan.");
        }

        // tar bort den givna siffran
        Console.Write("\nAnge index för att ta bort: "); // Användaren får ta bort ett index
        int indexToRemove = int.Parse(Console.ReadLine());

        // ta bort siffran om indexet är giltigt
        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
        {
            numbers.RemoveAt(indexToRemove);
            Console.WriteLine($"Siffran i index {indexToRemove} har tagits bort.");
        }
        else
        {
            Console.WriteLine("Ogiltigt index.");
        }


        // skriver ut listan efter ändringarna
        Console.WriteLine("\nListans innehåll efter ändringar:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"Index {i}: Värde {numbers[i]}");
        }
    }
}
