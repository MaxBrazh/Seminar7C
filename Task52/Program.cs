/* Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using static System.Console;
Clear();

int[,] arr = new int[,]
    {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
    };


printColAverage(arr);


void printColAverage(int[,]arr)
{
    Write("Arithmetic mean of each column: ");
    int[,] revertArr = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < revertArr.GetLength(0); i++)
    {
        for (int j = 0; j < revertArr.GetLength(1); j++)
        {
            revertArr[i,j] = arr[j,i];
        }
    }
    double[] counter=new double[revertArr.GetLength(0)];
    for (int i = 0; i < revertArr.GetLength(0); i++)
    {
        for (int j = 0; j < revertArr.GetLength(1); j++)
        {
            counter[i] += revertArr[i, j];
        }
        Write($"{Math.Round(counter[i]/ revertArr.GetLength(1),2)} ");
    }
}