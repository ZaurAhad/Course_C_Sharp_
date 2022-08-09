// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int a, int b) 
{
    int result = 1;
    for (int i = 1; i <= b; i++)
         result *= a;
    
    return result;
}

Console.WriteLine(Exponentiation(3, 5));
Console.WriteLine(Exponentiation(2, 4));