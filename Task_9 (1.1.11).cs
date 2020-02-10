/* Задание 1.1.11 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        double n;
        double factorial = 1;
        double x = 1;

        Console.Write("Введите число: ");
        n = Convert.ToDouble(Console.ReadLine());

        if (n >= 1)
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                x += 1 / factorial;
            }
        }

        Console.WriteLine($"Факториал = {factorial}\nОтвет: {x}");
    }
}
