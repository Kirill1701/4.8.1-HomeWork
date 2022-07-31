using System;

namespace _4._8._1_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int lines = int.Parse(Console.ReadLine());      // Переменная строки
            Console.Write("Введите количество столбцов: ");
            int columns = int.Parse(Console.ReadLine());    // Переменная столбцы

            int[,] matrix = new int[lines, columns];        // Задание массива из полученных чисел

            Random r = new Random();
            int sum = 0;                                    // Переменная суммы элементов

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = r.Next(100);             // Ограничение случайных чисел до 100
                    Console.Write($"{matrix[i, j]} ");
                    sum += matrix[i, j];
                }
                Console.WriteLine();
            }
            
            Console.WriteLine($"Сумма всех элементов матрицы: {sum}");
        }
    }
}
