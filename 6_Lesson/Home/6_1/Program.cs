// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования (использование дробных чисел)

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

double[] CopyMass(double[] arr) 
{
    double[] copyArr = new double[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }

    return copyArr;
}

double[] array = MassNums(10);
Print(array);
double[] copyArray = CopyMass(array);
Print(copyArray);

