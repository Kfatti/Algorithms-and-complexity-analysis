/* Задание 1.1.8 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int n;
        int factorial = 1;

        Console.Write("Введите число: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n >= 2)
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
        }

        Console.WriteLine($"Факториал = {factorial}");
    }
}
