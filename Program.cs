﻿// Задача 13: Напишите программу,
//  которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
   if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

string s = number.ToString();
char num = s[2];
int l = s.Length;

Console.WriteLine(num);

