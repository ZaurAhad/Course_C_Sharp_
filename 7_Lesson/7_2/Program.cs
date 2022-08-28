﻿// Задайте двумерный массив. Найдите элементы, у которых обе позиции четные, и замените эти элементы на их квадраты.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }    
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int[,] ReplaceElOn2ndPos2xArray(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i += 2)
    {
        for (int j = 1; j < arr.GetLength(1); j += 2)
        {
            arr[i, j]*= arr[i, j];
        }
        Console.WriteLine();
    }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
ReplaceElOn2ndPos2xArray(arr_1);
Print(arr_1);