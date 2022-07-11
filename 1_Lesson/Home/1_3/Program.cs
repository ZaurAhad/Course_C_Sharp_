// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber) 
{
    if (secondNumber > thirdNumber) 
    {
        Console.WriteLine("Первое число - максимальное");
    }         
    else if (secondNumber == thirdNumber) 
    {
        Console.WriteLine("Первое число - максимальное");
    }
}
else if (firstNumber < secondNumber)
{
        if (secondNumber > thirdNumber) 
    {
        Console.WriteLine("Второе число - максимальное");
    }         
    else if (secondNumber < thirdNumber) 
    {
        Console.WriteLine("Третье число - максимальное");
    }
    else 
    {
        Console.WriteLine("Второе и третье числа равны и больше первого");
    }
}
else if (firstNumber == secondNumber) 
{
    if (secondNumber == thirdNumber) 
    {
        Console.WriteLine("Все числа равны");
    }
    else if (secondNumber > thirdNumber)
    {
        Console.WriteLine("Первое и второе числа равны и больше третьего");
    }
    else 
    {
        Console.WriteLine("Третье число - максимальное");
    }
}
    
