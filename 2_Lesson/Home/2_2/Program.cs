// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

void CutSecondNumber(int a) 
{
    int num1 = a / 100;
    int num2 = a % 10;
    Console.WriteLine(num1 * 10 + num2);
}


int a = new Random().Next(100,1000);
Console.WriteLine(a);
CutSecondNumber(a);
