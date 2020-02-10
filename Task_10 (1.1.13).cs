/* Задание 1.1.13 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int a;
        int b;
        int k;

        Console.Write("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (a < b)
            k = a;
        else
            k = b;

        while ((a % k != 0) || (b % k != 0))
            k = k - 1;

        Console.WriteLine($"НОД: {k}");
    }
}
