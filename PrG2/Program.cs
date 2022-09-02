// See https://aka.ms/new-console-template for more information
//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int num = new Random().Next(100, 1000);
int a1 = num % 10;
int a2 = num / 100;
Console.WriteLine($"рандомной число = {num}");
Console.WriteLine($"преобразуемое число = {a2 * 10 + a1}");


