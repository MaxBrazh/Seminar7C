/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using static System.Console;
Clear();

Write("Задайте количество строк в массиве: ");
int m = int.Parse(ReadLine());
Write("Задайте количество столбцов в массиве: ");
int n = int.Parse(ReadLine());
double[,] array = new double[m, n];
Write("Укажите какое число найти в массиве: ");
int k = int.Parse(ReadLine());
newArray(array);
printArray(array);
printArrayDigit(array, k);


void newArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random x = new Random();
            array[i, j] = x.Next(20);
        }
    }
}


void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}  ");
        }
        WriteLine();
    }
}


void printArrayDigit(double[,] array, int k)
{
    int сount = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == k)
                WriteLine($"Число {k} найдено в массиве: строка {i + 1}, столбец {j + 1}");

            else сount++;
        }
    }
    if (сount == array.Length)
        WriteLine("Такого числа в массиве нет");
}