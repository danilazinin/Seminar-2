// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
int max = a;
if (b > max)
{
     max = b;
    if (max == a*a)
    {
        Console.WriteLine($"Число {b} является квадратом числа {a}");
    }
     else 
    {
        Console.WriteLine($"Число {b} НЕ является квадратом числа {a}");
    }
    
}
else
{
    if (max == b*b)
    {
        Console.WriteLine($"Число {a} является квадратом числа {b}");
    }
    else 
    {
        Console.WriteLine($"Число {a} НЕ является квадратом числа {b}");
    }
}
