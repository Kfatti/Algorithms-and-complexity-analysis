/* Задание 1.1.26 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int n;

        Console.Write("Введите число: ");
        n = Convert.ToInt32(Console.ReadLine());

        int b = 1;
        while (10 * b <= n)
            b *= 10;
        int k = n;
        while (b != 1)
        {
            Console.WriteLine(k / b);
            k %= b;
            b /= 10;
        }
        Console.WriteLine(k);
    }
}
