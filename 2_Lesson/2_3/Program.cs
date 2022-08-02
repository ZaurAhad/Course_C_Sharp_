

void Method1(int a, int b)
{
    if (a % b == 0) 
        Console.WriteLine("кратно");
    else
        Console.WriteLine($"не кратно {a % b}");
} 


Method1(25, 5);