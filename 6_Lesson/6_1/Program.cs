// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник такой длины.

void Triangle(int x, int y, int z)
{
    if ((x + y) > z && (x + z) > y && (y + z) > x)
    {
        Console.WriteLine("Существует");
    } 
    else
    {
        Console.WriteLine("Не существует");
    }
}

Triangle(4, 2, 5);