// Задача 58:  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//             Например, даны 2 матрицы:
//             2 4 | 3 4
//             3 2 | 3 3
//             Результирующая матрица будет:
//             6 16
//             9 6

Console.Write("Задайте размер двух матриц: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int[,] randomArray = new int[m, n];

void massiv(int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 10);
        }
    }
}

void printmassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
