/* Задание 1.1.5 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int k = 0;
        int c = 0;

        int a;
        Console.Write("Введите натуральное число A: ");
        a = Convert.ToInt32(Console.ReadLine());

        int b;
        Console.Write("Введите натуральное число B: ");
        b = Convert.ToInt32(Console.ReadLine());

        while (k != b)
        {
            k += 1;
            c += a;
        }

        Console.WriteLine($"Произведение этих чисел: {c}");
    }
}
