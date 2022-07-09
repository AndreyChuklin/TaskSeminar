Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
    
    if (number %2 == 0)
    {
        Console.WriteLine("Это четное число " + number);
    }
    else
    {
        Console.WriteLine("Это не четное число");
    }
