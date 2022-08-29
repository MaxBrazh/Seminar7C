/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using static System.Console;
Clear();

int[,] array = new int[,]
    {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
    };
printMiddleColum(array);

void printMiddleColum(int[,] array)
{
    WriteLine("Среднее арифметическое элементов в каждом столбце: ");
    int[,] backArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < backArray.GetLength(0); i++)
    {
        for (int j = 0; j < backArray.GetLength(1); j++)
        {
            backArray[i, j] = array[j, i];
        }
    }
    double[] count = new double[backArray.GetLength(0)];
    for (int i = 0; i < backArray.GetLength(0); i++)
    {
        for (int j = 0; j < backArray.GetLength(1); j++)
        {
            count[i] += backArray[i, j];
        }
        Write($"{Math.Round(count[i] / backArray.GetLength(1), 1)}; ");
    }
}