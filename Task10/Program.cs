﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите любое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit;

if (number < 0) 
{
    number = number * -1;
} 

if (99 < number && number < 1000)
{
    secondDigit = number % 100 / 10;
    Console.WriteLine((secondDigit));
}

else 
{
     Console.WriteLine("неверное число");
}