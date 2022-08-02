// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да 

bool Polindrom(int a) 
{
    return a / 10000 == a % 10 && (a % 10000 - a % 1000) / 1000 == (a % 100 - a % 10) / 10;
}
 

Console.WriteLine(Polindrom(14212));
Console.WriteLine(Polindrom(12821));
Console.WriteLine(Polindrom(23432));
