/* Задание 1.1.21 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int k = 0;
        int k_square = 0;
        int n;

        Console.Write("Введите число: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(k_square);
        while (k != n)
        {
            k += 1;
            k_square += k + k - 1;
            Console.WriteLine(k_square);
        }
    }
}
