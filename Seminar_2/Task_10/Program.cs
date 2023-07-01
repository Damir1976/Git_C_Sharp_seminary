// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//            и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
string? numberOne = Console.ReadLine();
int number = Convert.ToInt32(numberOne);
int number2 = number;
while (number < 100 || number >= 1000)
{
    Console.Write("Вы ввели не трехзначное число, повторите ввод: ");
    string? numberDouble = Console.ReadLine();
    number2 = Convert.ToInt32(numberDouble);
    number = number2;
}
number = number / 10 % 10;
Console.WriteLine($"Вторая цифра введенного числа {number} ");
