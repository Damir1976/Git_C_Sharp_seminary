// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//            и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, обозначающее день недели: ");
string? numberOne = Console.ReadLine();
int number = Convert.ToInt32(numberOne);
if (number < 1 || number > 7)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
else 
    {
    if (number >= 1 && number <= 5)
        {
            Console.WriteLine("Нет - это рабочие дни");
        }
            if (number == 6 || number == 7)
                    {
                        Console.WriteLine("Да - это выходные дни");
                    }
    }
