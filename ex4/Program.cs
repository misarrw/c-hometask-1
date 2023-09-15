// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Write number a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write number b: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write number c: ");
int c = int.Parse(Console.ReadLine()!);

if (a>b & a>c)
{
    Console.WriteLine("max = " + a);
}

else if (b>a & b>c)
{
    Console.WriteLine("max = " + b);
}

else if (c>a & c>b)
{
    Console.WriteLine("max = " + c);
}

else if (c>a & a==b)
{
    Console.WriteLine("max = " + c);
}

else if (a>b & b==c)
{
    Console.WriteLine("max = " + a);
}

else if (b>a & a==c)
{
    Console.WriteLine("max = " + b);
}

else if (a==b & a==c)

{
    Console.WriteLine("max = " + a);
}