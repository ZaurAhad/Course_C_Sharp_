﻿// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
int SumNum(int num) 
{
    int all_sum = 0;
    for(int i = 1; i <= num; i++) 
        all_sum += i;
    
    return all_sum;
}

Console.WriteLine(SumNum(7));