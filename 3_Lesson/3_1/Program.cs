void Quarters(int part) 
{
    if (part == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (part == 2)
        Console.WriteLine("x < 0, y > 0");
    else if (part == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (part == 4)
        Console.WriteLine("x > 0, y < 0");
    else
        Console.WriteLine("Error");
}

Quarters(3);
