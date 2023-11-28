using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string[] family = new string[] { "Peter", "Ann", "Alex", "Linda" };

        Console.WriteLine(showFamily(family));
    }

    public static string showFamily(string[] family)
    {
        if (family.Length == 0)
        {
            return "Семья пуста";
        }

        StringBuilder sb = new StringBuilder();

        sb.Append("Семья состоит из: ");

        for (int i = 0; i < family.Length; i++)
        {
            sb.Append(family[i]);

            if (i != family.Length - 1)
            {
                sb.Append(" ");
            }
        }

        return sb.ToString();
    }
}
