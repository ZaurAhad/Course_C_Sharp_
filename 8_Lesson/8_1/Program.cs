﻿// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку

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
    Console.WriteLine();
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

int [,] ReverseFirstEndRow(int[,] arr)
{
    int temp = 0;

    for(int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp;
    }
    return arr;
}
// Второй вариант реализации 
void FirstWithLast(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < column; i++)
    {
        (arr[0, i], arr[row - 1, i]) = (arr[row - 1, i], arr[0, i]);
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);
ReverseFirstEndRow(arr_1);
Print(arr_1);
FirstWithLast(arr_1);
Print(arr_1);