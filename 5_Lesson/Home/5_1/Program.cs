﻿// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Print(int[] arr) 
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
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
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void EvenCounter(int[] arr) 
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count ++;
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

int[] array = MassNums(5);
Print(array);
EvenCounter(array);
