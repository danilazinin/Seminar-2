// See https://aka.ms/new-console-template for more information

int num = new Random().Next(10,100);
Console.WriteLine($" рандомное число = {num}");
int a1 = num/10;
int a2 = num % 10;
int max = a1;
if (max < a2) 
{
    max = a2;
}
Console.WriteLine($"максимальное цифра в числе = {max}");