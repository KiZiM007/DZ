// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.Write($"Самое большое число {num1}");
    }
    else 
    {
        Console.Write($"Самое большое число {num3}");
    }
}
else
{
if (num2 > num3)
{
    Console.Write($"Самое большое число {num2}");
}
else
    Console.Write($"Самое большое число {num3}");    
}

