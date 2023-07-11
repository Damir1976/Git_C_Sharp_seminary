// Задача 62.  Напишите программу, которая заполнит спирально массив 4 на 4.
//             Например, на выходе получается вот такой массив:
//             01 02 03 04
//             12 13 14 05
//             11 16 15 06
//             10 09 08 07

Console.Write("Введите размерность прямоугольного двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int[,] array = new int[m, n];
int a = 1,
    b = 1,
    c = 1;

for (int y = 0; y < n; y++)
{
    array[0, y] = a;
    a++;
}
for (int x = 1; x < m; x++)
{
    array[x, n - 1] = a;
    a++;
}
for (int y = n - 2; y >= 0; y--)
{
    array[m - 1, y] = a;
    a++;
}
for (int x = m - 2; x > 0; x--)
{
    array[x, 0] = a;
    a++;
}

while (a < m * n)
{
    while (array[b, c + 1] == 0)
    {
        array[b, c] = a;
        a++;
        c++;
    }
    while (array[b + 1, c] == 0)
    {
        array[b, c] = a;
        a++;
        b++;
    }
    while (array[b, c - 1] == 0)
    {
        array[b, c] = a;
        a++;
        c--;
    }
    while (array[b - 1, c] == 0)
    {
        array[b, c] = a;
        a++;
        b--;
    }
}

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = a;
        }
    }
}

Console.WriteLine($"Заполненный спирально массив {n} на {m}: ");

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] < 10)
        {
            Console.Write(array[x, y] + ", " + "\t");
        }
        else
        {
            Console.Write(array[x, y] + ", " + "\t");
        }
    }
    Console.WriteLine('\t' + "");
}
