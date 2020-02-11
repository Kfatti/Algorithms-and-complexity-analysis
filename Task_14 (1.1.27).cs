/* Задание 1.1.27 */

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
        while (k != 0)
        {
            Console.WriteLine(k % 10);
            k /= 10;
        }
    }
}
