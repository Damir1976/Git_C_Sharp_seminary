// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//            или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
string? numberOne = Console.ReadLine();
int number = Convert.ToInt32(numberOne);
if (number < 100)
    {
        Console.WriteLine("Третьей цифры в числе нет");
    }
else
    {
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра введенного числа {number} ");
    }
