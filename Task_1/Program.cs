void Zadacha1()
{
    Console.WriteLine("На вход пришло два числа, 15 и 55. Из них: ");
    int number_1 = 15;
    int number_2 = 55;
    if (number_1 < number_2)
    {
        Console.WriteLine("Максимальное число " + number_2);
        Console.WriteLine("Минимальное число " + number_1);
    }
    else
    {
        Console.WriteLine("Максимальное число " + number_1);
        Console.WriteLine("Минимальное число " + number_2);
    }
}


void Zadacha2()
{
    Console.WriteLine("У нас есть три числа: 58, 66, -46. Из этих трех чисел максимальным будет: ");
    int number_1 = 58;
    int number_2 = 66;
    int number_3 = -46;
    int number_max = -1;

    if (number_1 >= number_max)
    {
        number_max = number_1;
    }

    if (number_2 >= number_max)
    {
        number_max = number_2;
    }

    if (number_3 >= number_max)
    {
        number_max = number_3;
    }

    Console.WriteLine("Число " + number_max);
}


void Zadacha3()
{
Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Это четное число " + number);
}
else
{
    Console.WriteLine("Это не четное число");
}
}

void Zadacha4()
{
int number = 99;
int start = 0;

while (start <= number)
{
    Console.Write(start + "  ");

    start += 1;

    start++;

}

Console.WriteLine();
}


//Zadacha1();
//Zadacha2();
//Zadacha3();
//Zadacha4();