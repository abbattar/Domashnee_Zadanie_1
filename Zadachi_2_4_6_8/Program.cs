// Эадание первое
/*
Console.WriteLine("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a > b)
{
    Console.Write(a);
    Console.Write(" больше ");
    Console.Write(b);
}
else
{
    Console.Write(b);
    Console.Write(" больше ");
    Console.Write(a);
}
*/
// Задание второе (Задача 4.)
/*
Console.WriteLine("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());

if (a > b)
{
    if(a > c)
    {
        Console.Write(a);
        Console.Write(" больше ");
        Console.Write(b);
        Console.Write(" и больше ");
        Console.Write(c);
    }
    else
    {
        Console.Write(c);
        Console.Write(" больше ");
        Console.Write(a);
        Console.Write(" и больше ");
        Console.Write(b);
    }
}
else
{
    if(b > c)
    {
        Console.Write(b);
        Console.Write(" больше ");
        Console.Write(a);
        Console.Write(" и больше ");
        Console.Write(c);
    }
    else
    {
        Console.Write(c);
        Console.Write(" больше ");
        Console.Write(a);
        Console.Write(" и больше ");
        Console.Write(b);
    }
}
*/
// Задача 6:
/*
Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.Write("Это чётное число");
}
else
{
    Console.Write("Это нечётное число");
}
*/
// Задача 8:
Console.WriteLine("Введите положительное целое число больше 1: ");
int a = Convert.ToInt32(Console.ReadLine()), b;
int index = 1;
if(a % 2 == 0)
{
    while(index <= a/2)
    {
        b = index * 2;        
        Console.Write(b);
        if(index < a/2)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(".");
        }
        index++;
    }
}
else
{
    while(index <= (a - 1)/2)
    {
        b = index * 2;
        Console.Write(b);
        if(index < a/2)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(".");
        }
        index++;
    }
}
