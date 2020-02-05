/* Задача 1.1.2. */

using System;

class Program
{
    static void Main()
    {
        int a; // Основная переменная A
        int b; // Основная переменная B

        Console.Write("Введите число A: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число B: ");
        b = Convert.ToInt32(Console.ReadLine());

        a += b;
        b = a - b;
        a -=b;

        Console.Write("Число A = " + a + "\n");
        Console.Write("Число B = " + b + "\n");
    }
}