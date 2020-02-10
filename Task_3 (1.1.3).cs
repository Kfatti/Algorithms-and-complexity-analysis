/* Задача 1.1.3. */

using System;

class Program
{
    static void Main()
    {
        int a; // переменная A
        int n; // Степень числа A
        double b;

        Console.Write("Введите число A: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите степень числа A: ");
        n = Convert.ToInt32(Console.ReadLine());

        b = Math.Pow(a, n);

        Console.Write($"Полученное число = {b} \n");
    }
}
