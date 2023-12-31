﻿// Задача 68:  Напишите программу вычисления функции Аккермана с помощью рекурсии.
//             Даны два неотрицательных числа m и n.
//             m = 2, n = 3 -> A(m,n) = 9
//             m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите 1-е неотрицательное число (не больше 3): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е неотрицательное число (не больше 7): ");
int n = Convert.ToInt32(Console.ReadLine());

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}

Console.Write($"Вычисленная функция Аккермана: A(m,n) = {A(m, n)} ");
