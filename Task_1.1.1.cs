/* Задача 1.1.1. */

using System;

class Program
{
    static void Main()
    {
        int a; // Основная переменная A
        int b; // Основная переменная B
        int t; // Переменная для замены

        Console.Write("Введите число A: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число B: ");
        b = Convert.ToInt32(Console.ReadLine());

        t = a;
        a = b;
        b = t;

        Console.Write("Число A = " + a + "\n");
        Console.Write("Число B = " + b + "\n");
    }
}
