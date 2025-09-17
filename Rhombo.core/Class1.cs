namespace Rhombo.core
{
    public class GetRhombus
    {
        public static string DrawRhombus(int size)
        {
            if (size < 1 || size % 2 == 0)
                throw new ArgumentException("The size must be an integer greater than zero.");

            var rhombus = new System.Text.StringBuilder();
            int mid = size / 2;

            for (int i = 0; i < size; i++)
            {
                int spaces = Math.Abs(mid - i);
                int stars = size - 2 * spaces;
                rhombus.Append(' ', spaces);

                for (int j = 0; j < stars; j++)
                {
                    if (j == 0 || j == stars - 1)
                        rhombus.Append('#');

                    else
                        rhombus.Append(' ');
                }
                rhombus.AppendLine();
            }
            return rhombus.ToString();

        }
    }
}

