// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом.
// [3 7 22 2 78] -> 76

void Print(double[] arr) 
{
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size) 
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return arr;
}

void Difference(double[] arr) 
{
    double sum = 0;
    double min = arr[0];
    double max = arr[0];
    double result = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        sum += arr[i];
        if (arr[i] < min)
            min = arr[i];
        if (arr[i] > max)
            max = arr[i];   
    }
    sum = Math.Round(sum, 2);
    result = sum - (min + max);
    result = Math.Round(result, 2);
    Console.WriteLine($"Разница между максимальным и минимальным элементом: {result}");
}

double[] array = MassNums(3);
Print(array);
Difference(array);