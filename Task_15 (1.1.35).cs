/* Задание 1.1.35 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int a;
        int b;

        Console.Write("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());

        int b1 = b;
        while (b1 <= a)
            b1 *= 2;
        int q = 0;
        int r = a;
        while (b1 != b)
        {
            b1 /= 2;
            q *= 2;
            if (r >= b1)
            {
                r -= b1;
                q += 1;
            }
        }
        Console.WriteLine($"Частное: {q}\nОстаток: {r}");
    }
}
