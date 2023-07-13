// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите любое трехзначное число");
int i = Convert.ToInt32(Console.ReadLine());
int thirdDigit;


if (i < 0) 
{
    i = i * -1;
} 
char[] arr = i.ToString().ToCharArray();

if (Array < 2)
{
    Console.WriteLine("третьей цифры нет");
}
     
else 
{
     thirdDigit = Array[2];
     Console.WriteLine((thirdDigit));
}
