// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ", 6);
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

string SearchElement(int[,] arr, int rowPos, int colPos)
{
    if (rowPos < arr.GetLength(0) || colPos < arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == rowPos - 1 && j == colPos - 1)
                return $"{arr[i, j]}";
            }
        }
    }
    return "No";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);
Console.Write("Enter the row position: ");
int rowPos = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int columnPos = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {SearchElement(arr_1,rowPos, columnPos)} находится на позиции {rowPos}, {columnPos}");