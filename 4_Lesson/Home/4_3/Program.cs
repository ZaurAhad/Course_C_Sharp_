// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Arr()
{
    int[] array = new int[8];

    for(int i = 0; i < array.Length; i++) 
    {
        array[i] = i + 1;
        Console.Write($"{array[i]} ");
    }
    
}
    
Arr();