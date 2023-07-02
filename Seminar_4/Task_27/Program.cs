// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadInt()
{
    Console.Write("Введите любое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Summa(int A)
{
    int summ = 0;
    while (A > 0)
    {
        summ += A % 10;
        A = A / 10;
    }
    return summ;
}

int A = ReadInt();
Console.Write($"Сумма цифр в числе {A} равна = {Summa(A)}");
