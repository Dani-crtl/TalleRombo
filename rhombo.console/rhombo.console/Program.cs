using Rhombo.core;
using System;   
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el tamaño del rombo:");
        if (int.TryParse(Console.ReadLine(), out int size))
        {
            try
            {
                string rhombus = GetRhombus.DrawRhombus(size);
                Console.WriteLine("\nRombo generado:\n");
                Console.WriteLine(rhombus);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Eroor: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number greater than zero.");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}