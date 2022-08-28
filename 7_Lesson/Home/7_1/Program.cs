// Задайте двумерный массив размером m x n, заполненный случайными вещественными числами

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ", 11);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 10), 1);
        }
    }
    return arr;
}

double[,] arr_1 = MassNums(3, 4);
Print(arr_1);