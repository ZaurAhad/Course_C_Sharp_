
void Checking(int N) 
{
    if (N % 7 == 0 && N % 23 == 0)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}

Console.WriteLine("Write a number N: ");
int n = int.Parse(Console.ReadLine());

Checking(n);