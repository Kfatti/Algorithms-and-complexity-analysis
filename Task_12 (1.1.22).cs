/* Задание 1.1.22 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int n;
        int l;

        Console.Write("Введите число: ");
        n = Convert.ToInt32(Console.ReadLine());

        int k = n;

        while (k != 1)
        {
            l = 2;
            while ((k % l) != 0)
                l += 1;
            Console.WriteLine(l);
            k /= l;
        }
    }
}
