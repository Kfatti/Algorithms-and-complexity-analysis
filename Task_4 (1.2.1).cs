/* Задание 1.2.1 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int length = 0;
        int[] myArr = new int[0];
        int n = 0; // Переменная для размера массива

        Console.Write("Введите размерность массива: ");
        n = Convert.ToInt32(Console.ReadLine());

        Array.Resize(ref myArr, myArr.Length + n);
        length = myArr.Length;

        foreach (int i in myArr)
        {
            myArr[i] = 0;
            Console.WriteLine(i);
        }

        Console.WriteLine("End.");
    }
}
