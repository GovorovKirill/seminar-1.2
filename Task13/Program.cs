// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit;

if (number > -99 && number < 100) 
{
    Console.WriteLine("третьей цифры нет");
}

else 
{
    if (number > 99 && number < 1000) 
    {
        thirdDigit = number % 10;
        Console.WriteLine((thirdDigit));
    }

    if (number < -99 && number > -1000) 
    {
        number = number * -1;
        thirdDigit = number % 10;
        Console.WriteLine((thirdDigit));
    }

    if (number > 999) 
    {
        while (number > 999) 
        {
            number = number / 10;
        }
        thirdDigit = number % 10;
        Console.WriteLine((thirdDigit));
    }

    if (number < -999) 
    {
        while (number < -999) 
        {
            number = number / 10;
        }
        number = number * -1;
        thirdDigit = number % 10;
        Console.WriteLine((thirdDigit));
    }
}