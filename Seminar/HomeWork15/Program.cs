﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1 || x > 7)
{
    Console.WriteLine("Нет такого дня недели");
}
if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5)
{
    Console.WriteLine("Сегодня рабочий день");
}
if (x == 6 || x == 7)
{
    Console.WriteLine("Сегодня выходной");
}