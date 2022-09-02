// See https://aka.ms/new-console-template for more information
//4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
  //14 -> нет 46 -> нет 161 -> да

Console.WriteLine("Введите  число");
int a = int.Parse(Console.ReadLine());

if (a % 23 == 0 && a % 7 == 0)
{
   Console.WriteLine(" число кратно 7 и 23");
}
else
{
    Console.WriteLine("оно не кратно");
}
