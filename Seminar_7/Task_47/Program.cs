// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//             m = 3, n = 4.
//             0,5 7 -2 -0,2
//             1 -3,3 8 -9,9
//             8 7,8 -7,1 9


Console.Write("Введите размерность двумерного массива по строкам (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность двумерного массива по столбцам (N): ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];

void massiv(int m, int n)
{
    Random rand = new Random();
    Console.Write($"Наш массив:");
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(-100, 100) / 10.0;
            Console.Write($"{randomArray[i, j]:F1} ");
        }
    }
}

massiv(m, n);
