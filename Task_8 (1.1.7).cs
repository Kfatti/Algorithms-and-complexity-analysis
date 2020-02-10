/* Задание 1.1.7 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int a; // Целое неотрицательное число (a >= 0)
        int d; // Целое положительное число (d > 0)

        Console.Write("Введите натуральное число: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ведите положительное число: ");
        d = Convert.ToInt32(Console.ReadLine());

        int r = a;
        int q = 0;

        while (r >= d)
        {
            r -= d;
            q += 1;
        }

        Console.WriteLine($"Частное: {q}");
        Console.WriteLine($"Остаток: {r}");
    }
}
