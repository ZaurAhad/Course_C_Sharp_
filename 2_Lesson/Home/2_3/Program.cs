// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int a)
{
    if (a / 100 != 0) 
    {
        Console.WriteLine(a % 10);
    }
    else 
    {
        Console.WriteLine("Нет третьей цифры в заданном числе");
    }
}


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
ThirdNumber(a);

