// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Write a number - ");
int N = int.Parse(Console.ReadLine()!);
int i = 2;

if (N%2==0)
{
    while (i<=N)
        {
            Console.Write(i);
    
            if (i<N)
            {
                Console.Write("," + " ");
            }
            i = i + 2;
        }   
}

else
{
    while (i<N)
    {
        Console.Write(i);

        if (N-i != 1)
        {
            Console.Write("," + " ");
        }
        i = i + 2;
    }
}

if (N<2)
{
    Console.Write("Numbers aren't found");
}