/*
Напишите программу, которая на вход принимает число и выдает его квадрат(число умноженное на само себя)
Пример:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число для возведения в квадрат");
int number = Convert.ToInt32(Console.ReadLine());
int squareOfNumber = number * number;

Console.WriteLine($"Квадрат числа {number} равен {squareOfNumber}");