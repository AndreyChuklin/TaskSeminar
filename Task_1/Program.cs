void Zadacha1()
{
Console.WriteLine("На вход пришло два числа, 10 и 55. Из них: ");
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

//Zadacha1();


Console.WriteLine("У нас есть три числа: 7, 66, 46. Из этих трех чисел максимальным будет: ");
int number_1 = 58;
int number_2 = -66;
int number_3 = -46;
int number_max = -1;
    
    if(number_1 >= number_max)
    {
        number_max = number_1;
    }
    
    if(number_2 >= number_max)
    {
        number_max = number_2;
    }
    
    if(number_3 >= number_max)
    {
        number_max = number_3;
    }
    
Console.WriteLine("Число " + number_max);
