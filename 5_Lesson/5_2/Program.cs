// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

int[] CrateArray()
{
    Console.WriteLine("Input number of elements");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Input element min");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Input element max");
    int max = int.Parse(Console.ReadLine());
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

void ArrayElementCounter(int[] array1) 
{
    Console.WriteLine("Input counting value");
    int s = int.Parse(Console.ReadLine());
    int a = 0;
    for (int i = 0; i < array1.Length; i++) 
    {
        if (array1[i] == s)
            a += 1;
    }
    if (s == 0)
        Console.WriteLine("This value isn't found in array");
    else
        Console.WriteLine($"This value is found in array {a} times");
}

ArrayElementCounter(CrateArray());