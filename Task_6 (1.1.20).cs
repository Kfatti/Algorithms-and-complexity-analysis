/* Задание 1.1.20 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int k;

        Console.Write("Введите, до какого числа вывести квадраты чисел: ");
        k = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= k; i++)
        {
            Console.WriteLine($"Квадрат числа {i} = {i * i}");
        }
    }
}
