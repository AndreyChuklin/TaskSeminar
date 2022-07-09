Console.WriteLine("У нас есть три числа: 7, 66, 46. Из этих трех чисел максимальным будет: ");
int number_1 = 7;
int number_2 = 66;
int number_3 = 46;
int number_max = 0;
    
    if(number_1 >= number_max)
    {
        number_max = number_1;
    }
    else
    {
        number_1 = number_max;
    }

    if(number_2 >= number_max)
    {
        number_max = number_2;
    }
    else
    {
        number_2 = number_max;
    }

    if(number_3 >= number_max)
    {
        number_max = number_3;
    }
    else
    {
        number_3 = number_max;
    }
Console.WriteLine("Число " + number_max);