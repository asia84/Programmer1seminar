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

