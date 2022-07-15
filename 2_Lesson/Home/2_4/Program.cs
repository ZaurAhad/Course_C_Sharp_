// Напишите программу, которая принимает на фход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend(int a) 
{
    if (a == 6 || a == 7) 
    {
        Console.WriteLine("Ура! Выходной!");
    }
    else if (a > 0 && a < 6)
    {
        Console.WriteLine("Пора работать");
    }
    else 
    {
        Console.WriteLine("Принимаю на свой счет только арабские цифры от 1 до 7 :)");
    }
}

Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7: ");
int a = int.Parse(Console.ReadLine());
Weekend(a);