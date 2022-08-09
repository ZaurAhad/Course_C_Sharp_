// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int a) 
{
    string num = a.ToString();
    int result = 0;
    int temp = 0;

    for(int i = 0; i < num.Length; i++) 
    {
        temp = a % 10;
        result += temp;
        a = a / 10;       
    }
    return result;
}


Console.WriteLine(Sum(452));
Console.WriteLine(Sum(82));
Console.WriteLine(Sum(9012));