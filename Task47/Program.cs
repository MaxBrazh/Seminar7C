/* Задача 47.Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using static System.Console;
Clear();

Write("Задайте количество строк в массиве: ");
int m = int.Parse(ReadLine());
Write("Задайте количество столбцов в массиве: ");
int n = int.Parse(ReadLine());
double[,] array = new double[m, n];

newArray(array);
printArray(array);


void newArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random x = new Random();
            array[i, j] = Convert.ToDouble(x.Next(-99, 99) / 10.0);
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