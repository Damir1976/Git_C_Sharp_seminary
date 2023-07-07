// Задача 54:  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//             элементы каждой строки двумерного массива.
//             Например, задан массив:
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//             В итоге получается вот такой массив:
//             7 4 2 1
//             9 5 3 2
//             8 4 4 2

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

void sortmassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int a = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = a;
                }
            }
        }
    }
}

massiv(m, n);
Console.WriteLine("Сгеренированный массив: ");
printmassiv(randomArray);
sortmassiv(randomArray);
Console.WriteLine("Упорядоченный массив: ");
printmassiv(randomArray);
