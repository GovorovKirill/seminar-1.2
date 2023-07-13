// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите цифру дня недели, я проверю, является ли этот день выходным");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0 || number > 7) 
{
    Console.WriteLine("нет такого дня недели");
}

else 
{
    if (number==6 || number==7) 
    {
        Console.WriteLine("да");
    }

    else 
    {
        Console.WriteLine("нет");
    }
}