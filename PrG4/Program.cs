// See https://aka.ms/new-console-template for more information

//12. Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
   Console.WriteLine("первое число кратно второму");
}
else
{
    double del2 = a % b;
    Console.WriteLine($"остаток = {del2}");
}

