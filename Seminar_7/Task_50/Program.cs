// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//            и возвращает значение этого элемента или же указание, что такого элемента нет.
//             Например, задан массив:
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//             17 -> такого числа в массиве нет

Console.Write("Введите размерность двумерного массива по строкам (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность двумерного массива по столбцам (N): ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];
Console.Write("Введите позицию строки: ");
int positionM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int positionN = Convert.ToInt32(Console.ReadLine());

void massiv(int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = Random.Shared.Next(1, 10);
            Console.Write($"{randomArray[i, j]}, ");
        }
        Console.WriteLine();
    }
}

massiv(m, n);

if (positionM <= randomArray.GetLength(0) && positionN-1 <= randomArray.GetLength(1)) 
        // было  if (positionM <= m - 1 && positionN <= n - 1)
{
    Console.Write($"Значение элемента = {randomArray[positionM-1, positionN-1]} ");
}
if (positionM > randomArray.GetLength(0) || positionN > randomArray.GetLength(1))      
        // было  if (positionM > m - 1 || positionN > n - 1)
{
    Console.Write("Такого элемента в массиве нет");
}

