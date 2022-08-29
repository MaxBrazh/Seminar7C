/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using static System.Console;
Clear();

Write("Rows in an array:");
int m=int.Parse(ReadLine());
Write("Columns in an array:");
int n = int.Parse(ReadLine());
double[,]arr=new double[m,n];
Write("What the number to find in the array:");
int digit=int.Parse(ReadLine());
fillArr(arr);
printArr(arr);
printArrDigit(arr,digit);

void fillArr(double[,]arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Random x = new Random();
            arr[i, j] = x.Next(10);

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
void printArrDigit(double[,] arr,int digit)
{
    int checkCounter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == digit) WriteLine($"The number {digit} found in the  {i + 1} row and in the {j + 1} collumn");
            else checkCounter++;
        }
    }
    if (checkCounter == arr.Length) WriteLine("There is no such number");
}