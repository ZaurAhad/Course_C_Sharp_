// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

void SecondNumber(int a) 
{
    Console.WriteLine(a % 100 / 10);
}

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
SecondNumber(num);