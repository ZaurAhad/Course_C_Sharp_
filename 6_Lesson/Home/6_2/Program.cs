// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
    
    Console.WriteLine("Сколько чисел вы введете: ");
    int size = int.Parse(Console.ReadLine());
    int count = 0;
    int i = 0;

    while (i < size) 
    {
        
        Console.WriteLine("Введите число: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
            count++;
            i++;
    }

    Console.WriteLine($"Вы ввели {count} чисел больше нуля");
