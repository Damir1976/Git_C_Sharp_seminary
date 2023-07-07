// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//            в каждом столбце.
//            Например, задан массив:
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//             Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размерность двумерного массива по строкам (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность двумерного массива по столбцам (N): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void massiv(int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
            Console.Write($"{randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void srednee(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    Random rand = new Random();
    for (int j = 0; j < n; j++)
    {
        int summa = 0;
        int s = 0;
        for (int i = 0; i < m; i++)
        {
            summa = summa + randomArray[i, j];
            s++;
        }
        Console.Write($"{summa / s:F1}; ");
    }
}
massiv(m, n);
srednee(m, n);
