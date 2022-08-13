// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 89, 6] -> 0

void Print(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size) 
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
    return arr;
}

void OddSum(int[] arr) 
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (i % 2 == 0)
            sum += arr[i];
    }
    Console.WriteLine($"Cумма элементов, стоящих на нечетных позициях: {sum}");
}

int[] array = MassNums(5);
Print(array);
OddSum(array);