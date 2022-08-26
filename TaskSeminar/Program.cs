/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.*/

// using static System.Console;
// using System.Linq;
// Clear();

// Write("Введите размер массива, минимальное и максимальное число через пробел:");
// int[] parameters = ReadLine().Split;
// PrintMatrixArray(parameters);

// int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] result = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintMatrixArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5.  */

// using static System.Console;
// using System.Linq;
// Clear();

// int[,] mat = GetMatrix(3, 4);
// PrintMatrix(mat);


// int[,] GetMatrix(int rows, int colums)
// {

//     int[,] result = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }

//     return result;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Write($"{matrix[i, j]} ");
//         }
//         WriteLine();
//     }

// }


/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
оба индекса чётные, и замените эти элементы на их квадраты. */

// using static System.Console;
// using System.Linq;
// Clear();

// int[,] mat = GetMatrix(6, 6);

// PrintMatrix(mat);
// NewMatrix(mat);
// WriteLine();

// PrintMatrix(mat);
// WriteLine();


// int[,] GetMatrix(int rows, int colums)
// {

//     int[,] result = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             result[i, j] = new Random().Next(-10, -2);
//         }
//     }

//     return result;

// }

// void NewMatrix(int[,] matt)
// {

//     for (int i = 2; i < matt.GetLength(0); i++)
//     {
//         for (int j = 2; j < matt.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matt[i, j] *= matt[i, j];
//             }
//         }
//     }

// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Write($"{matrix[i, j]}");
//         }
//         WriteLine();
//     }

// }


/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д. */

using static System.Console;
using System.Linq;
Clear();

int[,] mat = GetMatrix(4, 3);
PrintMatrix(mat);
WriteLine(NewMatrix(mat));


int[,] GetMatrix(int rows, int colums)
{
    int[,] result = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }

    return result;

}


int NewMatrix(int[,] matt)
{
    int sum = 0;

    for (int i = 0; i < matt.GetLength(0); i++)
    {
        for (int j = 0; j < matt.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matt[i, j];
            }
        }
    }
    return sum;

}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]}");
        }
        WriteLine();
    }

}


int GetSquareArray(int[,] inArray)
{
    int sum = 0;
    int size = inArray.GetLength(0) < inArray.GetLength(1) ? inArray.GetLength(0) : inArray.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        sum += inArray[i, i];
    }
    return sum;
}