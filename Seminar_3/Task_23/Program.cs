// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов: ");
for (int i = 1; i <= number; i++)
{
    // int kube = i * i * i;             Сделал вначале так по простому, а потом как на семинаре научили
    // Console.Write($"{kube}, ");       с использованием Math.Pow
    double kube = Math.Pow(i, 3);
    Console.Write($"{kube}, ");
}
