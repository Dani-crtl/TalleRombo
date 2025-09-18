namespace Rhombo.core
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
}

