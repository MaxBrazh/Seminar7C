/* Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

using static System.Console;
Clear();

Write("Strings in array:");
int m = int.Parse(ReadLine());
Write("Columns in an array:");
int n = int.Parse(ReadLine());
double[,] arr = new double[m, n];

fillArr(arr);
printArr(arr);


void fillArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random x = new Random();
            arr[i, j] = Convert.ToDouble(x.Next(-100, 100) / 10.0);

        }
    }
}
void printArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        Write("\n");
    }
}