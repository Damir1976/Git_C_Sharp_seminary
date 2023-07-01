// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//           какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9
// если равны то выдать что числа равны.

Console.Write("Введите первое число: ");
string? numberOne = Console.ReadLine();
int number1 = Convert.ToInt32(numberOne);
Console.Write("Введите второе число: ");
string? numberTwo = Console.ReadLine();
int number2 = Convert.ToInt32(numberTwo);
if (number1 > number2)
    {
        Console.Write("Max = ");
        Console.WriteLine(numberOne);
        Console.Write("Min = ");
        Console.WriteLine(numberTwo);
    }
else 
    {
        Console.Write("Max = ");
        Console.WriteLine(numberTwo);
        Console.Write("Min = ");
        Console.WriteLine(numberOne);
    }
if (number1 == number2)
    {
        Console.WriteLine("Оба числа равны между собой");
    }
