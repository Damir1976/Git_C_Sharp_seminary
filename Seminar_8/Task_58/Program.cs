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
int[,] randomArray1 = new int[m, n];
int[,] randomArray2 = new int[m, n];

void massiv(int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray1[i, j] = rand.Next(1, 6);
            randomArray2[i, j] = rand.Next(6, 10);
        }
    }
}

void printmassiv(int[,] randomArray)
{
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            Console.Write($"{randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

static int[,] doublemas(int[,] randomArray1, int[,] randomArray2)
{
    var doublemassiv = new int[randomArray1.GetLength(0), randomArray2.GetLength(1)];
    for (int i = 0; i < doublemassiv.GetLength(0); i++)
    {
        for (int j = 0; j < doublemassiv.GetLength(1); j++)
        {
            doublemassiv[i, j] += randomArray1[i, j] * randomArray2[i, j];
        }
    }
    //}
    return doublemassiv;
}

massiv(m, n);
Console.WriteLine("Сгеренированная 1-я матрица: ");
printmassiv(randomArray1);
Console.WriteLine("Сгеренированная 2-я матрица: ");
printmassiv(randomArray2);
Console.WriteLine("Результирующая матрица (произведение 2-х матриц): ");
printmassiv(doublemas(randomArray1, randomArray2));
