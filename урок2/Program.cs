// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число для проверки: ");

int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int squareOfNumber = numberB * numberB;
if (squareOfNumber == numberA)
    {
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");
    }
else
    {
    Console.WriteLine($"Число {numberB} не является квадратом числа {numberA}");  
    }

