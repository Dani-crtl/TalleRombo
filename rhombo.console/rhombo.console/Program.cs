class Program
{
    public class GetRhombus
    {

        public static string DrawRhombus(int size)
        {
            if (size < 1)
                throw new ArgumentException("The size must be an integer greater than zero.");

            var sb = new System.Text.StringBuilder();
            int mid = size / 2;

            for (int i = 0; i < size; i++)
            {
                int spaces = Math.Abs(mid - i);
                int stars = size - 2 * spaces - 2;

                sb.Append(' ', spaces);

                if (stars < 0)
                {
                    sb.Append('#');
                }
                else
                {
                    sb.Append('#');
                    sb.Append(' ', stars);
                    sb.Append('#');
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }

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